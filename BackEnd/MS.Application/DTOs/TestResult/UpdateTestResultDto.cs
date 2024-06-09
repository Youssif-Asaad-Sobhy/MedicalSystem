using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
namespace MS.Application.DTOs.TestResult
{
    public class UpdateTestResultDto
    {
        [Required]
        public int ID { get; set; }
        [Required, StringLength(100)]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int TestId { get; set; }
        [Required]
        public string ApplicationUserId { get; set; }

    }
}