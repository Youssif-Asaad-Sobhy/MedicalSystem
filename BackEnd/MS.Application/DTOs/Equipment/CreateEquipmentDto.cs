using System.ComponentModel.DataAnnotations;

namespace MS.Application.DTOs.Equipment
{
    public class CreateEquipmentDto
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
