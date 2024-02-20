using System.ComponentModel.DataAnnotations;

namespace MS.Application.DTOs.ReportMedicine
{
    public class UpdateReportMedicineDto
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public int ReportID { get; set; }

        [Required]
        public int MedicineTypeID { get; set; }
    }
}
