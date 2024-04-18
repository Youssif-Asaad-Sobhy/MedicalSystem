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
    public class Shift
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int EntityID { get; set; }
        public PlaceType PlaceType { get; set; }
        public ICollection<PlaceShift > PlaceShifts { get; set; }
    }
}
