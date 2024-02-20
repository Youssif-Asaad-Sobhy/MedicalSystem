using System;
using System.ComponentModel.DataAnnotations;
using MS.Data.Enums;

namespace MS.Application.DTOs.Reservation
{
    public class CreateReservationDto
    {
        [Required]
        public DateTime Time { get; set; }

        [Required]
        public ReservationState State { get; set; }

        [Required]
        public PlaceType PlaceType { get; set; }

        [Required]
        public int EntityID { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public string UserID { get; set; }
    }
}
