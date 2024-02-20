using System.ComponentModel.DataAnnotations;

namespace MS.Application.DTOs.ReportMedicine
{
    public class CreateReportMedicineDto
    {
        [Required]
        public int ReportID { get; set; }

        [Required]
        public int MedicineTypeID { get; set; }
    }
}
