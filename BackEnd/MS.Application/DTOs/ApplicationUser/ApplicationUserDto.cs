using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.DTOs.ApplicationUser
{
    public class ApplicationUserDto 
    {
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string NID { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public bool IsRegister { get; set; }
        public string? BloodType { get; set; }
        public string? MaritalStatus { get; set; }
        public IList<string> Roles { get; set; }
    }
}
