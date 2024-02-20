using System.ComponentModel.DataAnnotations;
using MS.Data.Enums;

namespace MS.Application.DTOs.Lab
{
    public class UpdateLabDto
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public LabType Type { get; set; }

        [Required]
        public int HospitalID { get; set; }
    }
}
