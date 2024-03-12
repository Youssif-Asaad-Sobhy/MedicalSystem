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
        Task<object> SendEmailAsync(string mailTo);
        Task<bool> VerifyOTP(string userEmailAddress,string enteredOTP);
    }
}
