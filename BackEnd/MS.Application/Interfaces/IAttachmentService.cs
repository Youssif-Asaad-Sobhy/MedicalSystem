using MS.Application.DTOs.Attachment;
using MS.Application.DTOs.Department;
using MS.Application.DTOs.Document;
using MS.Application.Helpers.Response;
using MS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.Interfaces
{
    public interface IAttachmentService
    {
        Task<Response<FileDto>> GetByIdAsync(int Id);
        Task<Response<FileDto>> GetByFileNameAsync(string fileName);
        Task<Response<List<FileDto>>> GetAllFilesAsync();
        Task<Response<FileDto>> UploadFileAsync(UploadFileDTO fileDTO);
        Task<byte[]> DownloadFileAsync(DownloadFileDTO downloadFileDTO);
        Task<Response<FileDto >> DeleteAsync(int Id);
        Task<string> GetFileType(string fileName);
    }
}
