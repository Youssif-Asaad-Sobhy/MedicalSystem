using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
        public Enums.EntityType EntityType { get; set; }
        public IEntity Entity { get; set; }
        public int ShiftID { get; set; }
        public Shift Shift { get; set; }
    }
}
