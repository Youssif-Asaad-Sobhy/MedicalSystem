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
        [Required , StringLength(20)]
        public string  FirstName { get; set; }
        [Required,StringLength(20)]
        public string LastName { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }
        public string Phone { get; set; }
        [Required,StringLength(14)]
        public string NID { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
    }
}
