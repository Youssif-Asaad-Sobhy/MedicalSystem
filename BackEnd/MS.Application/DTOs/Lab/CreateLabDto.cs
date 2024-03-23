using MS.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MS.Data.Enums;

namespace MS.Application.DTOs.Lab
{
    public class CreateLabDto
    {
        [Required, StringLength(25)]
        public string Name { get; set; }

        [Required,Range(1,2)]
        public LabType Type { get; set; }

        [Required]
        public int HospitalID { get; set; }
    }
}
