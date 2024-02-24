using System;
using System.ComponentModel.DataAnnotations;

namespace MS.Application.DTOs.Report
{
    public class UpdateReportDto
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "ID must be a positive integer")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Time is required")]
        public DateTime Time { get; set; }
        
        [Required]
        [MaxLength(1000, ErrorMessage = "Description cannot exceed 1000 characters")]
        public string Description { get; set; }

        [Required(ErrorMessage = "UserID is required")]
        public string UserID { get; set; }

        [Required(ErrorMessage = "DoctorID is required")]
        public string DoctorID { get; set; }
    }
}