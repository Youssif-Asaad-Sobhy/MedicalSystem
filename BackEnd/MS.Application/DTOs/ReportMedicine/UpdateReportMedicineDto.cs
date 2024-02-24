using System.ComponentModel.DataAnnotations;

namespace MS.Application.DTOs.ReportMedicine
{
    public class UpdateReportMedicineDto
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "ID must be a positive integer")]
        public int ID { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "ReportID must be a positive integer")]
        public int ReportID { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "MedicineTypeID must be a positive integer")]
        public int MedicineTypeID { get; set; }
    }
}
