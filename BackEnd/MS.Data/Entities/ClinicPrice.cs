﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Data.Entities
{
    public class ClinicPrice
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int ClinicID { get; set; }
        public Clinic Clinic { get; set; }
    }
}
