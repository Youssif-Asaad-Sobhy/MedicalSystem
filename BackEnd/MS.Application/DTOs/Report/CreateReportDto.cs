using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace MS.Application.DTOs.Report
{
    public class CreateReportDto
    {

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