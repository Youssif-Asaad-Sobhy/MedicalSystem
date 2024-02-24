using MS.Data.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace MS.Application.DTOs.Shift
{
    public class UpdateShiftDto
    {
        [Required]
        public int ID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "StartTime is required")]
        public DateTime StartTime { get; set; }

        [Required(ErrorMessage = "EndTime is required")]
        public DateTime EndTime { get; set; }

        [Required(ErrorMessage = "EntityID is required")]
        [Range(1, int.MaxValue, ErrorMessage = "EntityID must be a positive integer")]
        public int EntityID { get; set; }
        
        [Required]
        [MaxLength(1)]
        public PlaceType PlaceType { get; set; }
    }
}