using System.ComponentModel.DataAnnotations;

namespace MS.Application.DTOs.Pharmacy
{
    public class CreatePharmacyDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int HospitalID { get; set; }
    }
}
