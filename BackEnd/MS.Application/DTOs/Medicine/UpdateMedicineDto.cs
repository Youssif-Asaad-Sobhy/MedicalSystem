using System.ComponentModel.DataAnnotations;

namespace MS.Application.DTOs.Medicine
{
    public class UpdateMedicineDto
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
