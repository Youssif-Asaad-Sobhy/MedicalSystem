using MS.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.DTOs.Reservation
{
    public class ClinicReservationDto
    {
        [Required,StringLength(14)]
        public string UserID { get; set; }
        public PlaceType PlaceType { get; set; } = PlaceType.Clinic;  
        [Required]
        public int ClinicID { get; set; }
        [Required]
        public double Price { get; set; }

        
    }
}
