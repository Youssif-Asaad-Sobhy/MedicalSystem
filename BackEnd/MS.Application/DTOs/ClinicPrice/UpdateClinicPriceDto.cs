using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.DTOs.ClinicPrice
{
    public class UpdateClinicPriceDto
    {
        [Required]
        public int ID { get; set;}
        [Required]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int ClinicID { get; set; }
    }
}
