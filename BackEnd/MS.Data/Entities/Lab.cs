using MS.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Data.Entities
{
    public class Lab
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public LabType Type { get; set; }
        public int ShiftID { get; set; }
        public int HospitalID { get; set; }
        public Hospital hospital { get; set; }
        public ICollection<TestLab> testLabs { get; set; }

    }
}
