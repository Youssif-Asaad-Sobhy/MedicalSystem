using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MS.Application.DTOs.Hospital;
using MS.Data.Enums;

namespace MS.Application.DTOs.Lab
{
    public class DetailedLab
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public LabType Type { get; set; }
        public int HospitalID { get; set; }
        public DetailedHospital Hospital { get; set; }
    }
}