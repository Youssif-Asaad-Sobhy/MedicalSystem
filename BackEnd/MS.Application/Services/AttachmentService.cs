using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.StaticFiles;
using MimeKit;
using MS.Application.DTOs.Attachment;
using MS.Application.DTOs.Document;
using MS.Application.Helpers.Response;
using MS.Application.Interfaces;
using MS.Data.Entities;
using MS.Infrastructure.Repositories.UnitOfWork;
using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.Services
{
    public class AttachmentService: IAttachmentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IWebHostEnvironment _env;
        public AttachmentService(IUnitOfWork unitOfWorke, IHttpContextAccessor httpContextAccessor, IWebHostEnvironment env)
        {
            _unitOfWork = unitOfWorke;
            _httpContextAccessor = httpContextAccessor;
            _env = env;
        }
        public async Task<Response<FileDto>> DeleteAsync(int Id)
        {
            var file = await _unitOfWork.Attachment.GetByIdAsync(Id);
            if (file == null)
            {
                return ResponseHandler.NotFound<FileDto>("The File Does Not Exist");
            }
            var filePath = GetFilePath(file.FolderName, file.FileName);
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                await _unitOfWork.Attachment.DeleteAsync(file);
            }
            return ResponseHandler.Deleted<FileDto>();
        }

        public async Task<byte[]> DownloadFileAsync(DownloadFileDTO downloadFileDTO)
        {
            var filePath = Path.Combine(_env.WebRootPath, downloadFileDTO.FolderName, downloadFileDTO.FileName);
            if (filePath is null)
            {
                return null;
            }
            return await File.ReadAllBytesAsync(filePath);
        }

        public async Task<Response<List<FileDto>>> GetAllFilesAsync()
        {
            var files = await _unitOfWork.Attachment.GetAllAsync();
            if (files == null)
            {
                return ResponseHandler.NotFound<List<FileDto>>("There Are No Files");
            }
            var fileDTOs = files.Select(f => new FileDto
            {
                Title = f.Title,
                FileName = f.FileName,
                FolderName = f.FolderName,
                FilePath = f.Filepath,
                ViewUrl = f.ViewUrl,
                Type = f.Type,
                DownloadUrl = f.DownloadUrl,
            }).ToList();
            return ResponseHandler.Success(fileDTOs);
        }

        public async Task<Response<FileDto>> GetByFileNameAsync(string fileName)
        {
             var file =await _unitOfWork.Attachment.GetByExpressionSingleAsync(f => f.FileName == fileName);
            if (file is null)
                return ResponseHandler.NotFound<FileDto>("File Does Not Exist");
            var fileDTO =new FileDto
            {
                Title = file.Title,
                FileName = file.FileName,
                FolderName = file.FolderName,
                FilePath = file.Filepath,
                ViewUrl = file.ViewUrl,
                Type = file.Type,
                DownloadUrl = file.DownloadUrl,
            };
            return ResponseHandler.Success(fileDTO);
        }

        public async Task<Response<FileDto>> GetByIdAsync(int Id)
        {
            var file = await _unitOfWork.Attachment.GetByIdAsync(Id);
            if (file == null)
            {
                return ResponseHandler.NotFound<FileDto>("The File Does Not Exist");
            }
            return ResponseHandler.Success(new FileDto
            {
                Title=file.Title,
                FileName = file.FileName,
                FolderName = file.FolderName,
                FilePath = file.Filepath,
                ViewUrl = file.ViewUrl,
                Type = file.Type,
                DownloadUrl = file.DownloadUrl,
            });

        }

        public async Task<string> GetFileType(string fileName)
        {
            var fileExtension =Path.GetExtension(fileName);
            var provider = new FileExtensionContentTypeProvider();
            if (!provider.TryGetContentType(fileName, out var contentType))
            {
                contentType = "application/octet-stream";
            }
            return contentType;
        }

        public async Task<Response<FileDto>> UploadFileAsync(UploadFileDTO fileDTO)
        {
            var folderName = fileDTO.FolderName;
            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(fileDTO.File.FileName);

            var folderPath = Path.Combine(_env.WebRootPath, folderName);
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            var filePath = Path.Combine(folderPath, fileName);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await fileDTO.File.CopyToAsync(stream);
            }
            var url = $"{_httpContextAccessor.HttpContext.Request.Scheme}://" +
                      $"{_httpContextAccessor.HttpContext.Request.Host}" +
                      $"/api/Attachment";
            var viewUrl = $"{url}/ViewFile?FolderName={folderName}&FileName={fileName}";
            var downloadUrl = $"{url}/DownloadFile?FolderName={folderName}&FileName={fileName}";
            var file = new Attachment()
            {
                Title = fileDTO.File.FileName,
                FileName = fileName,
                FolderName = folderName,
                Filepath = filePath,
                ViewUrl = viewUrl,
                DownloadUrl = downloadUrl,
                TestId = fileDTO.FolderName == "Test" ? fileDTO.ParentId : 0,
                ClinicId = fileDTO.FolderName == "Clinic" ? fileDTO.ParentId : 0,
                UserDiseaseId = fileDTO.FolderName == "UserDisease" ? fileDTO.ParentId : 0,
                Type = fileDTO.File.ContentType,
            };
            await _unitOfWork.Attachment.AddAsync(file);
            return ResponseHandler.Success(new FileDto
            {
                Title = file.Title,
                FileName = file.FileName,
                FolderName = file.FolderName,
                FilePath = file.Filepath,
                ViewUrl = file.ViewUrl,
                Type = file.Type,
                DownloadUrl = file.DownloadUrl,
            });
        }
        private string GetFilePath(string folderName, string fileName)
        {
            var filePath = Path.Combine(_env.WebRootPath, folderName, fileName);
            if (File.Exists(filePath))
            {
                return filePath;
            }
            return null;
        }
    }
}
