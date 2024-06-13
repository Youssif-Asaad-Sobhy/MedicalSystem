using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MS.Data.Enums;

namespace MS.Application.DTOs.Shift
{
    public class DetailedShift
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int EntityID { get; set; }
        public PlaceType PlaceType { get; set; }
    }
}
