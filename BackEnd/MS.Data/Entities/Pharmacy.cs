using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Data.Entities
{
    public class Pharmacy
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int HospitalID { get; set; }
        public int ShiftID { get; set; }

    }
}
