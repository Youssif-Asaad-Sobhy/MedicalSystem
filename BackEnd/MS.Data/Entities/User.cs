using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Data.Entities
{
    public class User: IdentityUser
    {
        public int ID { get; set; }
        public string Name { get; set; }
        //public string Email { get; set; }
        //public string Phone { get; set; }
        //public string password { get; set; }
        public string NID { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Report> Reports { get; set; }
        public ICollection<Reservation> Reservations { get; set; }

    }
}
