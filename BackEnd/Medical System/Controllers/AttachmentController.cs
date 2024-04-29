using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MS.Application.DTOs.Attachment;
using MS.Application.DTOs.Department;
using MS.Application.DTOs.Document;
using MS.Application.Helpers.Response;
using MS.Application.Interfaces;

namespace Medical_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttachmentController : ControllerBase
    {
        #region Constructor/props
        private readonly IAttachmentService _attachmentService;
        public AttachmentController(IAttachmentService attachmentService)
        {
            _attachmentService=attachmentService;
        }
        #endregion

        #region Methods
        [HttpGet("{ID:int}")]
        public async Task<IActionResult> GetSingleClincAsync([FromRoute] int ID)
        {
            var response = await _attachmentService.GetByIdAsync(ID);
            return this.CreateResponse(response);
        }
        [HttpGet("Get-All")]
        public async Task<IActionResult> GetAllClinicAsync()
        {
            var response = await _attachmentService.GetAllFilesAsync();
            return this.CreateResponse(response);
        }


        [HttpDelete("{ID:int}")]
        public async Task<IActionResult> DeleteSingleAsync(int ID)
        {
            var response = await _attachmentService.DeleteAsync(ID);
            return this.CreateResponse(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateClinicAsync([FromForm] UploadFileDTO uploadFileDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _attachmentService.UploadFileAsync(uploadFileDto);
            return this.CreateResponse(response);
        }
        [HttpGet("ViewFile")]
        public async Task<IActionResult> ViewFile([FromQuery] DownloadFileDTO downloadFileDTO)
        {
            var type = await _attachmentService.GetFileType(downloadFileDTO.FileName);
            var response = await _attachmentService.DownloadFileAsync(downloadFileDTO);
            return File(response, type);
        }
        [HttpGet("DownloadFile")]
        public async Task<IActionResult> DownloadFile([FromQuery] DownloadFileDTO downloadFileDTO)
        {
            var type = await _attachmentService.GetFileType(downloadFileDTO.FileName);
            var response = await _attachmentService.DownloadFileAsync(downloadFileDTO);
            return File(response, type, downloadFileDTO.FileName);
        }
        #endregion
    }
}
