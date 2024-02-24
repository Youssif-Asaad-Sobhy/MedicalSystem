using MS.Data.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace MS.Application.DTOs.Reservation
{
    public class UpdateReservationDto
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "ID must be a positive integer")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Time is required")]
        [RegularExpression(@"^\d{4}-\d{2}-\d{2}T\d{2}:\d{2}:\d{2}$", ErrorMessage = "Time must be in the format yyyy-MM-ddTHH:mm:ss")]
        public string Time { get; set; }

        [Required]
        [MaxLength(1)]
        public ReservationState State { get; set; }

        [Required]
        [MaxLength(1)]
        public PlaceType PlaceType { get; set; }

        [Required(ErrorMessage = "EntityID is required")]
        [Range(1, int.MaxValue, ErrorMessage = "EntityID must be a positive integer")]
        public int EntityID { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(0, double.MaxValue, ErrorMessage = "Price must be a positive number")]
        public double Price { get; set; }

        [Required(ErrorMessage = "UserID is required")]
        public string UserID { get; set; }

    }
}