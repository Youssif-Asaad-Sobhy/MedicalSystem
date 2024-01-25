using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Data.Entities
{
    public class TestLab
    {
        public int ID { get; set; }
        public int TestID { get; set; }
        public int LabID { get; set; }

        public double Price { get; set; }
        public string Description { get; set; }
        public Lab lab { get; set; }
        public Tests tests { get; set; }
    }
}
