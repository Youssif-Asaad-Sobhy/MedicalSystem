using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.DTOs.ApplicationUser
{
    public class UpdateUserDto
    {
        [Required]
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string NID { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsRegister { get; set; }
        public string? BloodType { get; set; }
        public string? MaritalStatus { get; set; }
        public string[] Roles { get; set; }
    }
}
