using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.DTOs.Equipment
{
    public class CreateEquipmentDto
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
