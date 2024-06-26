﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using MS.Application.DTOs.Attachment;
using MS.Application.DTOs.Test;
using MS.Data.Entities;
namespace MS.Application.DTOs.TestResult
{
    public class GetAllTestResultDto
    {
        // TestResultDto
        public string Title { get; set; }
        public string Description { get; set; }
        public int TestId { get; set; }
        // TestDto
        public TestDto Test { get; set; }
        // FileDto  
        public ICollection<FileDto> Files { get; set; }
    }
}