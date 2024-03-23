using MS.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Data.Entities
{
    public class PlacePrice 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int PlaceID { get; set; }
        public PlaceType PlaceType { get; set; }
    }
}
