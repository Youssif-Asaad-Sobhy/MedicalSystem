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
namespace MS.Application.Services
{
    public class MailingService : IMailingService
    {
        private readonly MailSettings _mailSettings;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public static readonly TimeSpan ExpirationDuration = TimeSpan.FromMinutes(10);

        public MailingService(IOptions<MailSettings> mailSettings, IHttpContextAccessor httpContextAccessor)
        {
            _mailSettings = mailSettings.Value;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<string> SendEmailAsync(string mailTo)
        {
            string otp = OTPHelper.GenerateOTP();
            string body = $"<p>Your OTP is: {otp}</p>";

            var email = new MimeMessage
            {
                Sender = MailboxAddress.Parse(_mailSettings.Email),
                Subject = "OTP"
            };

            email.To.Add(MailboxAddress.Parse(mailTo));

            var builder = new BodyBuilder();
            // if i have attachment
            //if (attachments != null)
            //{
            //    byte[] fileBytes;
            //    foreach (var file in attachments)
            //    {
            //        if (file.Length > 0)
            //        {
            //            using var ms = new MemoryStream();
            //            file.CopyTo(ms);
            //            fileBytes = ms.ToArray();

            //            builder.Attachments.Add(file.FileName, fileBytes, ContentType.Parse(file.ContentType));
            //        }
            //    }
            //}
            DateTime expirationTime = DateTime.UtcNow.Add(ExpirationDuration);

            // Store OTP and expiration time in session
            _httpContextAccessor.HttpContext.Session.SetString("StoredOTP", otp);
            _httpContextAccessor.HttpContext.Session.SetString("OTPExpiration", expirationTime.ToString("o"));
            _httpContextAccessor.HttpContext.Session.SetString("UserEmailAddress", mailTo);
            builder.HtmlBody = body;
            email.Body = builder.ToMessageBody();
            email.From.Add(new MailboxAddress(_mailSettings.DisplayName, _mailSettings.Email));

            using var smtp = new MailKit.Net.Smtp.SmtpClient();
            smtp.Connect(_mailSettings.Host, _mailSettings.Port);
            //Console.WriteLine(_mailSettings.Password);
            smtp.Authenticate(_mailSettings.Email, _mailSettings.Password);
            await smtp.SendAsync(email);

            smtp.Disconnect(true);
            return otp;
        }

        public bool VerifyOTP(string enteredOTP)
        {

            string storedOTP = _httpContextAccessor.HttpContext.Session.GetString("StoredOTP");
            DateTime expirationTime = DateTime.Parse(_httpContextAccessor.HttpContext.Session.GetString("OTPExpiration"));
            string userEmailAddress = _httpContextAccessor.HttpContext.Session.GetString("UserEmailAddress");
            // Check if OTP has expired
            if (DateTime.UtcNow > expirationTime)
            {
                // OTP has expired
                return false;
            }

            // Compare the entered OTP with the stored OTP
            return enteredOTP == storedOTP && userEmailAddress != null;
        }
    }
}
