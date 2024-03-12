using MS.Data.Entities;
using MS.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.DTOs.Reservation
{
    public class ReservationDto
    {
        public int ID { get; set; }
        public DateTime Time { get; set; }
        public int SerialNumber { get; set; }
        public ReservationState State { get; set; }
        public int PlacePriceId { get; set; }
        public string UserID { get; set; }
    }
}
