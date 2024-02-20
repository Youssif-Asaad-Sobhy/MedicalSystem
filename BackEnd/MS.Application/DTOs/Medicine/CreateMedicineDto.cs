using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.DTOs.Medicine
{
    public class CreateMedicineDto
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
