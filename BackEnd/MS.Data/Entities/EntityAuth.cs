﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Data.Entities
{
    public class EntityAuth
    {
        public int ID { get; set; }
        public int UID { get; set; }
        public EntityType EType { get; set; }
        public int EntityID {  get; set; } 
    }
}
