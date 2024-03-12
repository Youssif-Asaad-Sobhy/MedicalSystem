using MailKit.Security;
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
        public async Task SendEmailAsync(string mailTo)
        {
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
                throw new Exception("user is null here ");
            }
            var otpEntity = new OTP
            {
                Code = otp,
                UserID = user.Id,
                Email = user.Email,
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
            _unitOfWork.OTPs.AddAsync(otpEntity);

        }

        public async Task<bool> VerifyOTP(string userEmailAddress, string enteredOTP)
        {
            var otpEntity = await _unitOfWork.OTPs
                .GetByExpressionSingleAsync(o => o.Email == userEmailAddress && o.ExpirationTime > DateTime.UtcNow);

            if (otpEntity == null)
            {
                // OTP not found or expired
                return false;
            }

            // Compare the entered OTP with the stored OTP
            return enteredOTP == otpEntity.Code;
        }
    }
}
