using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MS.Application.DTOs.Hospital;

namespace MS.Application.DTOs.Pharmacy
{
    public class DetailedPharmacy
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int HospitalID { get; set; }
        public DetailedHospital Hospital { get; set; }
    }
}
