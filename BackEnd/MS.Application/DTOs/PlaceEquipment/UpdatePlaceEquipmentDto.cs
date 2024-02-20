using MS.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace MS.Application.DTOs.PlaceEquipment
{
    public class UpdatePlaceEquipmentDto
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public int EquipmentID { get; set; }

        [Required]
        public int EntityID { get; set; }

        [Required]
        public PlaceType PlaceType { get; set; }
    }
}
