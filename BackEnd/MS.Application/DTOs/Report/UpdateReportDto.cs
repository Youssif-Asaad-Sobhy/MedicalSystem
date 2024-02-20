using System;
using System.ComponentModel.DataAnnotations;

namespace MS.Application.DTOs.Report
{
    public class UpdateReportDto
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public DateTime Time { get; set; }

        public string Description { get; set; }

        [Required]
        public string UserID { get; set; }

        [Required]
        public int DoctorID { get; set; }
    }
}
