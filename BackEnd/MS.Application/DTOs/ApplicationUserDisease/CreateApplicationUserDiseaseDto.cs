using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace MS.Application.DTOs.ApplicationUserDisease
{
    public class CreateApplicationUserDiseaseDto
    {
        [Required, StringLength(50)]
        public string Type { get; set; }

        [Required]
        public double ValueResult { get; set; }

        [Required, StringLength(500)]
        public string Description { get; set; }

        [Range(0, double.MaxValue)]
        public double? Height { get; set; }

        [Range(0, double.MaxValue)]
        public double? Weight { get; set; }

        [Required]
        public required string UserId { get; set; }

        [Required]
        public required int DiseaseId { get; set; }

        [Required, StringLength(500)]
        public string Diagnosis { get; set; }

        [Required]
        public DateTime DiagnosisDate { get; set; }
        public IFormFile? Photo { get; set; }
    }
}