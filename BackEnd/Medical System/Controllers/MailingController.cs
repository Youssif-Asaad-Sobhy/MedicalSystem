using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MS.Application.Helpers.OTP;
using MS.Application.Interfaces;
using MS.Application.Services;

namespace Medical_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailingController : ControllerBase
    {
        private readonly IMailingService _mailingService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public MailingController(IMailingService mailingService, IHttpContextAccessor httpContextAccessor)
        {
            _mailingService = mailingService;
            _httpContextAccessor = httpContextAccessor;
        }
        [HttpPost("send")]
        public async Task<IActionResult> SendMail([FromForm] MailRequestDto dto)
        {
            string otp = await _mailingService.SendEmailAsync(dto.ToEmail);
            return Ok(new { OTP = otp, Expiration = DateTime.UtcNow.Add(MailingService.ExpirationDuration) });
        }

        [HttpPost("verify-otp")]
        public IActionResult VerifyOTP([FromBody] VerifyOTPRequest request)
        {
            bool isOTPValid = _mailingService.VerifyOTP(request.EnteredOTP);

            if (isOTPValid)
            {
                return Ok(new { Message = "OTP verification successful" });
            }
            else
            {
                return BadRequest(new { Message = "Invalid OTP or expired" });
            }
        }
    }
}
