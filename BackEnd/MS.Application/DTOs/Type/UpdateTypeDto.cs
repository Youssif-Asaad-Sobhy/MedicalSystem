using System;
using System.ComponentModel.DataAnnotations;

namespace MS.Application.DTOs.Types
{
    public class UpdateTypeDto
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
