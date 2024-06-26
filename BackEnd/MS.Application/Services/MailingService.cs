﻿using MailKit.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using MailKit.Net.Smtp;
using MimeKit;
using MS.Application.Helpers.OTP;
using MS.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using MS.Data.Entities;
using Microsoft.AspNetCore.Identity;
using MS.Infrastructure.Repositories.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using MS.Application.Helpers.Response;
namespace MS.Application.Services
{
    public class MailingService : IMailingService
    {
        private readonly MailSettings _mailSettings;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUnitOfWork _unitOfWork;

        public MailingService(IOptions<MailSettings> mailSettings, UserManager<ApplicationUser> userManager, IUnitOfWork unitOfWork)
        {
            _mailSettings = mailSettings.Value;
            _userManager = userManager;
            _unitOfWork = unitOfWork;
        }
        public async Task<Response<object>> SendEmailAsync(string mailTo)
        {
            if (!IsValidEmail(mailTo))
            {
                return ResponseHandler.BadRequest<object>("Invalid email address.");
            }

            string otp = OTPHelper.GenerateOTP();
            string body = $"<p>Your OTP is: {otp}</p>";

            var email = new MimeMessage
            {
                Sender = MailboxAddress.Parse(_mailSettings.Email),
                Subject = "OTP"
            };

            email.To.Add(MailboxAddress.Parse(mailTo));
            var user = await _userManager.FindByEmailAsync(mailTo);
            if (user == null)
            {
                return ResponseHandler.BadRequest<object>("User Is Null");
            }
             
            var otpEntity = new OTP
            {
                Code = otp,
                UserID = user.Id,
                Email = mailTo,
                ExpirationTime = DateTime.UtcNow.Add(TimeSpan.FromMinutes(10))
            };


            var builder = new BodyBuilder();
            builder.HtmlBody = body;
            email.Body = builder.ToMessageBody();
            email.From.Add(new MailboxAddress(_mailSettings.DisplayName, _mailSettings.Email));

            using var smtp = new MailKit.Net.Smtp.SmtpClient();
            smtp.Connect(_mailSettings.Host, _mailSettings.Port);
            //Console.WriteLine(_mailSettings.Password);
            smtp.Authenticate(_mailSettings.Email, _mailSettings.Password);
            await smtp.SendAsync(email);

            smtp.Disconnect(true);

            await _unitOfWork.OTPs.AddAsync(otpEntity);
            return ResponseHandler.Success<object>("Sent Ya 8aly");
        }
        private bool IsValidEmail(string email)
        {
                var addr = new MailAddress(email);
                return addr.Address == email;
        }

        public async Task<Response<bool>> VerifyOTP(string userEmailAddress, string enteredOTP)
        {
            var otpEntity = await _unitOfWork.OTPs
                .GetByExpressionSingleAsync(o => o.Email == userEmailAddress && o.Code == enteredOTP && o.ExpirationTime > DateTime.UtcNow);

            if (otpEntity == null)
            {
                // OTP not found or expired
                return ResponseHandler.BadRequest<bool>("Invalid OTP or expired");
            }
            var user = await _userManager.FindByEmailAsync(userEmailAddress);
            if (user == null)
            {
                return ResponseHandler.BadRequest<bool>("User Is Null here");
            }
            if (enteredOTP== otpEntity.Code)
            {
                user.EmailConfirmed = true;
                await _userManager.UpdateAsync(user);
                return ResponseHandler.Success(true);
            }
            // Compare the entered OTP with the stored OTP


            return ResponseHandler.BadRequest<bool>("Invalid OTP or expired");
        }
    }
}
