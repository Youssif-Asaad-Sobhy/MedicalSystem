using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MS.Data.Enums;

namespace MS.Application.DTOs.PlacePrice
{
    public class DetailedPlacePrice
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int PlaceID { get; set; }
        public PlaceType PlaceType { get; set; }
    }
}
