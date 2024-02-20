using System.ComponentModel.DataAnnotations;

namespace MS.Application.DTOs.Pharmacy
{
    public class UpdatePharmacyDto
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int HospitalID { get; set; }
    }
}
