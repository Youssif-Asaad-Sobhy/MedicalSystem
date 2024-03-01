using MS.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.DTOs.Reservation
{
    public class PlaceReservationDto
    {
        [Required,StringLength(14)]
        public string UserID { get; set; }
        [Required]
        public int PlacePriceId { get; set; }

        
    }
}
