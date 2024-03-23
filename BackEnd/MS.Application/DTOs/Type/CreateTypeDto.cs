using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MS.Application.DTOs.Types
{
    public class CreateTypeDto
    {
        [Required]
        public string Name { get; set; }
    }
}
