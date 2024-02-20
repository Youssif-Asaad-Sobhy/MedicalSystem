using MS.Data.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace MS.Application.DTOs.Shift
{
    public class CreateShiftDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [Required]
        public int EntityID { get; set; }

        [Required]
        public PlaceType PlaceType { get; set; }
    }
}
