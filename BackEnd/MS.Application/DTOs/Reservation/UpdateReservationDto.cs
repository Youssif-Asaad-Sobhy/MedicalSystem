using MS.Data.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace MS.Application.DTOs.Reservation
{
    public class UpdateReservationDto
    {
        [Required]
        public int ID { get; set; }

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
