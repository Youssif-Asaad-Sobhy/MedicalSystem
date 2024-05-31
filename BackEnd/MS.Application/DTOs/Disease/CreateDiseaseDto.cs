﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace MS.Application.DTOs.Disease
{
    public class CreateDiseaseDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Symptoms { get; set; }

        [Required]
        public string Causes { get; set; }
    }
}