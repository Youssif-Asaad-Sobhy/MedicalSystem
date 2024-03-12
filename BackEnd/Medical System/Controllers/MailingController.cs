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

        public MailingController(IMailingService mailingService)
        {
            _mailingService = mailingService;
        }
        [HttpPost("send")]
        public async Task<IActionResult> SendMail(MailRequestDto dto)
        {
            var res=await _mailingService.SendEmailAsync(dto.ToEmail);
            return Ok(res);
        }

        [HttpPost("verify-otp")]
        public async Task<IActionResult> VerifyOTP([FromBody] VerifyOTPRequest request)
        {
            bool isOTPValid =await _mailingService.VerifyOTP(request.Email,request.EnteredOTP);

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
