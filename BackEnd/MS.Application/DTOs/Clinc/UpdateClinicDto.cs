using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MS.Data.Enums;
namespace MS.Application.DTOs.Clinc
{
    public class UpdateClinicDto
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        
        [Required]
        public int DepartmentID { get; set; }
        public string Description { get; set; }
        public List<WeekDays> WorkDays { get; set; }

        [Required]
        public int PhotoID { get; set; }
    }
}
