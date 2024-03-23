using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MS.Data.Enums;
using MS.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Data.Entities
{
    public class PlaceShift
    {
        public int ID { get; set; }
        public int EntityID { get; set; }
        public PlaceType PlaceType { get; set; }
        public int ShiftID { get; set; }
        public Shift Shift { get; set; }
    }
}
