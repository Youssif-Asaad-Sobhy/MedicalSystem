using Microsoft.AspNetCore.Http;
using MS.Application.DTOs.Attachment;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.DTOs.ApplicationUserDisease
{
    public class ApplicationUserDiseaseDto
    {
        public int ID { get; set; }
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
        public required string ApplicationUserId { get; set; }

        [Required]
        public required int DiseaseId { get; set; }

        [Required, StringLength(500)]
        public string Diagnosis { get; set; }

        [Required]
        public DateTime DiagnosisDate { get; set; }
        public List<FileDto> Attachments { get; set; }
    }
}
