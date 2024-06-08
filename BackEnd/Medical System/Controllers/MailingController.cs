using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MS.Application.Helpers.OTP;
using MS.Application.Helpers.Response;
using MS.Application.Interfaces;
using MS.Application.Services;

namespace Medical_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MailingController : ControllerBase
    {
        private readonly IMailingService _mailingService;

        public MailingController(IMailingService mailingService)
        {
            _mailingService = mailingService;
        }
        [HttpPost("send")]
        public async Task<IActionResult> SendMail([FromQuery]MailRequestDto dto)
        {
            var res=await _mailingService.SendEmailAsync(dto.ToEmail);
            return this.CreateResponse(res);
        }

        [HttpPost("verify-otp")]
        public async Task<IActionResult> VerifyOTP([FromQuery] VerifyOTPRequest request)
        {
            var isOTPValid =await _mailingService.VerifyOTP(request.Email,request.EnteredOTP);

            return this.CreateResponse(isOTPValid);
        }
    }
}
