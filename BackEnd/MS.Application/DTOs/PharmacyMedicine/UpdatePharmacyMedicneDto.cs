using System.ComponentModel.DataAnnotations;

namespace MS.Application.DTOs.PharmacyMedicine
{
    public class UpdatePharmacyMedicineDto
    {
        [Required]
        public int ID { get; set; }

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
