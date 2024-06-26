﻿using Microsoft.AspNetCore.Http;
using MS.Application.Helpers.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.Interfaces
{
    public interface IMailingService
    {
        Task<Response<object>> SendEmailAsync(string mailTo);
        Task<Response<bool>> VerifyOTP(string userEmailAddress,string enteredOTP);
    }
}
