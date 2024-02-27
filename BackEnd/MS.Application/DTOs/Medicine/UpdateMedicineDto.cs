using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.DTOs.Medicine
{
    public class UpdateMedicineDto
    {
        [Required]
        public int ID { get; set; }

        [Required,StringLength(50)]
        public string Name { get; set; }
    }
}
