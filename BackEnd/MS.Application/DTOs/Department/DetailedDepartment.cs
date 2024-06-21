using MS.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MS.Application.DTOs.Hospital;

namespace MS.Application.DTOs.Department
{
    public class DetailedDepartment
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int HospitalID { get; set; }
        public DetailedHospital Hospital { get; set; }
    }
}
