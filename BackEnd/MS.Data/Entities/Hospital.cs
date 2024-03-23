using MS.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Data.Entities
{
    public class Hospital
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Government { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public HospitalType Type { get; set; } 
        public ICollection<Department> Departments { get; set; }
        public ICollection<Lab> Labs { get; set; }
        public ICollection<Pharmacy> Pharmacies { get; set; }
    }
}
