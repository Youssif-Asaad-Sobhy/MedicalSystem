using System.ComponentModel.DataAnnotations;

namespace MS.Application.DTOs.Medicine
{
    public class CreateMedicineDto
    {
        [Required]
        public string Name { get; set; }
    }
}
