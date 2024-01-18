using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MS.Data.Enums;
namespace MS.Data.Entities
{
    public class Reservation
    {
        public int ID { get; set; }
        public DateTime Time{ get; set; }
        public int UserID {  get; set; }
        public ReservationState State { get; set; }
        public EntityType EntityType { get; set; }
        public int EntityID { get; set; }
        public double Price { get; set; }

    }
}
