using System.ComponentModel.DataAnnotations;
using MS.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.DTOs.Hospital
{
    public class CreateHospitalDto
    {
        [Required, StringLength(50)]
        public string Name { get; set; }

        public string Phone { get; set; }

        [Required, StringLength(25)]
        public string Government { get; set; }

        [Required,StringLength(25)]
        public string City { get; set; }

        [Required,StringLength(25)]
        public string Country { get; set; }

        [Required,Range(1,2)]
        public HospitalType Type { get; set; }
    }
}
