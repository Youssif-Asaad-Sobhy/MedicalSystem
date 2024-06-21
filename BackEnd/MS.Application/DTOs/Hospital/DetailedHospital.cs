using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MS.Data.Enums;

namespace MS.Application.DTOs.Hospital
{
    public class DetailedHospital
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Government { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public HospitalType Type { get; set; } 
    }
}
