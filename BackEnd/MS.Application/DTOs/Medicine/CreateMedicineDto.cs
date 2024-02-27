﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.DTOs.Medicine
{
    public class CreateMedicineDto
    {
        [Required,StringLength(50)]
        public string Name { get; set; }
    }
}
