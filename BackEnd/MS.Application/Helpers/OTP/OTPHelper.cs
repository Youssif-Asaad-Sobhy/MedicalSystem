using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.Helpers.OTP
{
    public static class OTPHelper
    {
        public static string GenerateOTP()
        {
            // Generate a 6-digit random numeric OTP
            Random random = new Random();
            int otpValue = random.Next(100000, 999999);

            return otpValue.ToString();
        }
    }
}
