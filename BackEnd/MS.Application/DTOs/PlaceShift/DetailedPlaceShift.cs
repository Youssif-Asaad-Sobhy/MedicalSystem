using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MS.Application.DTOs.Shift;
using MS.Data.Enums;

namespace MS.Application.DTOs.PlaceShift
{
    public class DetailedPlaceShift
    {
        public int ID { get; set; }
        public int EntityID { get; set; }
        public PlaceType PlaceType { get; set; }
        public int ShiftID { get; set; }
        public DetailedShift Shift { get; set; }
    }
}
