﻿using MS.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.DTOs.EntityAuth
{
    internal class UpdateEntityAuthDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int UserID { get; set; }
        [Required]
        public PlaceType PlaceType { get; set; }
        [Required]
        public int EntityID { get; set; }
    }
}
