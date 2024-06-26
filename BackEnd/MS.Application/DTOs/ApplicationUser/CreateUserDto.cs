﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.DTOs.ApplicationUser
{
    public class CreateUserDto
    {
        [Required, StringLength(20)]
        public string FirstName { get; set; }
        [Required , StringLength(20)]
        public string LastName { get; set; }
        [Required, StringLength(50)]
        public string UserName { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        public string Phone { get; set; }
        [Required, StringLength(14)]
        public string NID { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public DateOnly BirthDate { get; set; }
        
        public bool IsRegister { get; set; }
        
        public string? BloodType { get; set; }
        
        public string? MaritalStatus { get; set; }
        public string[] Roles { get; set; }
    }
}
