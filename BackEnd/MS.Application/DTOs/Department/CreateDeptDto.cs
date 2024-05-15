using MS.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.DTOs.Department
{
    public class CreateDeptDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int HospitalID { get; set; }
    }
}
