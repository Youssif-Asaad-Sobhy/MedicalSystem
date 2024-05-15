using System;
using System.ComponentModel.DataAnnotations;

namespace MS.Application.DTOs.Types
{
    public class UpdateTypeDto
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "ID must be a positive integer")]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
