﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Data.Entities
{
    public class Tests
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<TestLab> testLabs { get; set; }
    }
}
