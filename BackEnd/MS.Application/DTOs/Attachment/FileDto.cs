using MS.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.DTOs.Attachment
{
    public class FileDto
    {
        public  int ID { get; set; }
        public required string Title { get; set; }
        public required string FileName { get; set; }
        public required string FolderName { get; set; }
        public required string FilePath { get; set; }
        public required string ViewUrl { get; set; }
        public required string DownloadUrl { get; set; }
        public required string Type { get; set; }
        public DateTime Creation { get; set; }=DateTime.Now;
    }
}
