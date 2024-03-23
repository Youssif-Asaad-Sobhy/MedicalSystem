using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Data.Entities
{
    public class Equipment
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<PlaceEquipment> PlaceEquipments { get; set; }
    }
}
