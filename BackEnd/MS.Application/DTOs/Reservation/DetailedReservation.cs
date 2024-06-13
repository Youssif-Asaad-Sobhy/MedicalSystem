using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MS.Application.DTOs.PlacePrice;
using MS.Data.Enums;

namespace MS.Application.DTOs.Reservation
{
    public class DetailedReservation
    {
        public int ID { get; set; }
        public DateTime Time{ get; set; }
        public string SerialNumber { get; set; } 
        public ReservationState State { get; set; }
        public int PlacePriceId {  get; set; }
        public string UserID {  get; set; }
        public DetailedPlacePrice PlacePrice { get; set; }
        public Data.Entities.ApplicationUser User { get; set; }
    }
}
