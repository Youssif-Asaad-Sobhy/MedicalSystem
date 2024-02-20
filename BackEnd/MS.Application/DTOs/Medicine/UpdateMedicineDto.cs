using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.DTOs.Medicine
{
    internal class UpdateMedicineDto
    {
        [Required]
        public string Name { get; set; }
    }
}
