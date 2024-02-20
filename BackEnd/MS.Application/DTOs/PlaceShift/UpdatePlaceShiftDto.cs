using MS.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace MS.Application.DTOs.PlaceShift
{
    public class UpdatePlaceShiftDto
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public int EntityID { get; set; }

        [Required]
        public PlaceType PlaceType { get; set; }

        [Required]
        public int ShiftID { get; set; }
    }
}
