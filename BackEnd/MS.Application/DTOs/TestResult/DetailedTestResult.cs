using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MS.Application.DTOs.Attachment;
using MS.Application.DTOs.Test;
using MS.Data.Entities;
namespace MS.Application.DTOs.TestResult
{
    public class DetailedTestResult
    {
        // TestResultDto
        public string Title { get; set; }
        public string Description { get; set; }
        public int TestId { get; set; }
        // TestDto
        public DetailedTest Test { get; set; }
        // FileDto  
        public ICollection<FileDto> Files { get; set; }
        public string ApplicationUserId { get; set; }
        
    }
}
