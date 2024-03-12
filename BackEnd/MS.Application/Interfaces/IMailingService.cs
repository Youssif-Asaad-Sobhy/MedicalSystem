using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.Interfaces
{
    public interface IMailingService
    {
        Task<string> SendEmailAsync(string mailTo);
        bool VerifyOTP(string enteredOTP);
    }
}
