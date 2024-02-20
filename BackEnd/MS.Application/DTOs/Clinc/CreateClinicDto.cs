﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.DTOs.Clinc
{
    public class CreateClinicDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int DepartmentID { get; set; }
    }
}