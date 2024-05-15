using MS.Application.DTOs.Shift;
using MS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.DTOs.Clinc
{
    public class DetailedClinic
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DepartmentID { get; set; }
        public string description { get; set; }
        public int reservationCount { get; set; }
        public string DepartmentName { get; set; }
        public double Price { get; set; }
        public int PhotoID { get; set; }
        public string Photo { get; set; }
        public List<ShiftBasicData> Shifts { get; set; }
    }
}
