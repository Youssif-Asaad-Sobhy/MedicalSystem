using System.ComponentModel.DataAnnotations;

namespace MS.Application.DTOs.Equipment
{
    public class UpdateEquipmentDto
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
