using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MS.Data.Entities;
namespace MS.Application.DTOs.ApplicationUserDisease
{
    public class UpdateApplicationUserDiseaseDto
    {
        [Required]
        public int ID { get; set; }
        
        [Required, StringLength(50)]
        public string Type { get; set; }

        [Required, Range(0, double.MaxValue)]
        public double ValueResult { get; set; }

        [Required, StringLength(500)]
        public string Description { get; set; }

        [Range(0, double.MaxValue)]
        public double? Height { get; set; }

        [Range(0, double.MaxValue)]
        public double? Weight { get; set; }

        [Required, StringLength(50)]
        public string ApplicationUserId { get; set; }

        [Required]
        public int DiseaseId { get; set; }

        [Required, StringLength(500)]
        public string Diagnosis { get; set; }

        [Required]
        public DateTime DiagnosisDate { get; set; }
    }
}