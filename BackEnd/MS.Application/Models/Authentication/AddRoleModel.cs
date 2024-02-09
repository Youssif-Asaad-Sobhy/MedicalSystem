using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.Models.Authentication
{
    public class AddRoleModel
    {
        [Required]
        public string Userid { get; set; }
        [Required]
        public string RoleName { get; set; }
    }
}
