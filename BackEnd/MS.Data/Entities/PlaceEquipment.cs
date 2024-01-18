using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Data.Entities
{
    public class PlaceEquipment
    {
        public int ID { get; set; }
        public int EquipmentID { get; set; }
        public int EntityID { get; set; }
        public EntityType EType { get; set; }

    }
}