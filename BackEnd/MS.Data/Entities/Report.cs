﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Data.Entities
{
    public class Report
    {
        public int ID { get; set; }
        public DateTime Time { get; set; }
        public string Description { get; set; }
        public int UserID { get; set; }
        public int DoctorID { get; set; }
    }
}
