using MS.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.DTOs.ClinicPrice
{
    public class CreatePlacePriceDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public PlaceType PlaceType  { get; set; }
        [Required]
        public int PlaceID { get; set; }
    }
}
