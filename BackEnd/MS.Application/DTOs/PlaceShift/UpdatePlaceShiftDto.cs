using MS.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace MS.Application.DTOs.PlaceShift
{
    public class UpdatePlaceShiftDto
    {
        [Required]
        public int ID { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "EntityID must be a positive integer")]
        public int EntityID { get; set; }

        [Required]
        [MaxLength(1)]
        public PlaceType PlaceType { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "ShiftID must be a positive integer")]
        public int ShiftID { get; set; }
    }
}
