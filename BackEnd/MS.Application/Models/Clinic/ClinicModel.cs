using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.Models.Clinic
{
    public class ClinicModel
    {
        public int ID { get; set; }
        [StringLength(50), Required]
        public string Name { get; set; }
        [Required]
        public int DepartmentID { get; set;}
    }
}
