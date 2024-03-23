using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.DTOs.Reservation
{
    public class UserReservationDetails
    {
        public string firstname { get; set; } 
        public string lastname { get; set; }
        public string Nid { get; set; }
        public string PlaceName { get; set; }
        public double Price { get; set; }
        public DateTime Time { get; set; }
        public int Waiting {  get; set; }
    }
}
