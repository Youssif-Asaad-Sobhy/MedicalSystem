using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.Models.Authentication
{
    public class RegisterDto
    {
        [Required, StringLength(14)]
        public string NID { get; set; }
        [StringLength(20)]
        public string Name { get; set; }
        [StringLength(50)]
        public string UserName { get; set; }
        [ StringLength(100)]
        public string Email { get; set; }
        [StringLength(7)]
        public string Gender { get; set; }
        [Required, StringLength(20)]
        public string Password { get; set; }
        [Required, Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
