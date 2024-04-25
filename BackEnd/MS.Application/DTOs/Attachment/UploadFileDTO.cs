using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.DTOs.Attachment
{
    public class UploadFileDTO
    {
        public required IFormFile File { get; set; }
        public required string FolderName { get; set; }
        public required int ParentId { get; set; }
    }
}
