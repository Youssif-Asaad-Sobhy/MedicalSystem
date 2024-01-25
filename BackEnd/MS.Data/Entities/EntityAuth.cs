using MS.Data.Enums;
using MS.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Data.Entities
{
    public class EntityAuth
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public EntityType EntityType { get; set; }
        public int EntityID {  get; set; } 
        public IEntity Entity { get; set; }
    }
}
