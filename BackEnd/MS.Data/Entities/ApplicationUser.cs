using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Data.Entities
{
    public class ApplicationUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NID { get; set; }
        public string Gender { get; set; }
        public bool IsRegister { get; set; }
        public string? BloodType { get; set; }
        public string? MaritalStatus { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
        public ICollection<ApplicationUserDisease> UserDiseases { get; set; }
        public ICollection<TestResult> TestResults { get; set; }

    }
}
