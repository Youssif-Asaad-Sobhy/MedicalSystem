using System.ComponentModel.DataAnnotations;

namespace MS.Application.DTOs.PharmacyMedicine
{
    public class CreatePharmacyMedicineDto
    {
        [Required]
        public int PharmacyID { get; set; }

        [Required]
        public int MedicineTypeID { get; set; }

        [Required]
        public int Amount { get; set; }

        [Required]
        public double Price { get; set; }
    }
}
