using System.ComponentModel.DataAnnotations;
using MS.Data.Enums;

namespace MS.Application.DTOs.Hospital
{
    public class CreateHospitalDto
    {
        [Required]
        public string Name { get; set; }

        public string Phone { get; set; }

        [Required]
        public string Government { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public HospitalType Type { get; set; }
    }
}
