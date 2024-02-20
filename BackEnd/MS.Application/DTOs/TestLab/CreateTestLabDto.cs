﻿using System.ComponentModel.DataAnnotations;

namespace MS.Application.DTOs.TestLab
{
    public class CreateTestLabDto
    {
        [Required]
        public int TestLabID { get; set; }

        [Required]
        public int LabID { get; set; }

        [Required]
        public double Price { get; set; }

        public string Description { get; set; }
    }
}
