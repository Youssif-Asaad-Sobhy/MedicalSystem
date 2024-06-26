﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.Models.Authentication
{
    public class AuthDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public bool IsAuthenticted { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string NID { get; set; }
        public List<string> Roles { get; set; }
        public DateTime ExpiresOn { get; set; }
        public string Token { get; set; }
    }
}
