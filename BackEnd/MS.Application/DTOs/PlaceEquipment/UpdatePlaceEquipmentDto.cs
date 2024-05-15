using MS.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace MS.Application.DTOs.PlaceEquipment
{
    public class UpdatePlaceEquipmentDto
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "ID must be a positive integer")]
        public int ID { get; set; }

        [Required(ErrorMessage = "EquipmentID is required")]
        [Range(1, int.MaxValue, ErrorMessage = "EquipmentID must be a positive integer")]
        public int EquipmentID { get; set; }

        [Required(ErrorMessage = "EntityID is required")]
        [Range(1, int.MaxValue, ErrorMessage = "EntityID must be a positive integer")]
        public int EntityID { get; set; }

        [Required(ErrorMessage = "PlaceType is required")]
        [MaxLength(1)]
        public PlaceType PlaceType { get; set; }
    }
}
