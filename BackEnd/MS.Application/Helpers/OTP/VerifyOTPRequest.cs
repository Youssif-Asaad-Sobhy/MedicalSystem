using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.Helpers.OTP
{
    public class VerifyOTPRequest
    {
        [Required]
        public string EnteredOTP { get; set; }

    }
}
