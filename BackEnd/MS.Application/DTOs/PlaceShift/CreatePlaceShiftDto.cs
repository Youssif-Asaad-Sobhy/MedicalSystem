using MS.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace MS.Application.DTOs.PlaceShift
{
    public class CreatePlaceShiftDto
    {
        [Required]
        public int EntityID { get; set; }

        [Required]
        public PlaceType PlaceType { get; set; }

        [Required]
        public int ShiftID { get; set; }
    }
}
