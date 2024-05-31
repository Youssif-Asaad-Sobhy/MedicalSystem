using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MS.Application.DTOs.ApplicationUser;
using MS.Application.DTOs.Document;
using MS.Application.Helpers.Response;
using MS.Application.Interfaces;
using MS.Application.Services;
using MS.Data.Entities;

namespace Medical_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUserController : ControllerBase
    {

        #region Constructor/props
        private readonly IApplicationUserService _applicationService;
        private readonly UserManager<ApplicationUser> _userManager;

        public ApplicationUserController(IApplicationUserService applicationService, UserManager<ApplicationUser> userManager)
        {
            _applicationService = applicationService;
            _userManager = userManager;
        }
        #endregion

        #region Methods
        [HttpGet("{ID}")]
        public async Task<IActionResult> GetSingleUserAsync([FromRoute] string ID)
        {
            var response = await _applicationService.GetUserByIDAsync(ID);

            return this.CreateResponse(response);
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("DeleteUser/{ID}")]
        public async Task<IActionResult> DeleteSingleAsync(string ID)
        {
            var response = await _applicationService.DeleteUserAsync(ID);

            return this.CreateResponse(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUserAsync([FromBody] CreateUserDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _applicationService.CreateUserAsync(model);

            return this.CreateResponse(response);
        }
        [Authorize]
        [HttpPut]
        public async Task<IActionResult> PutSingleAsync([FromBody] UpdateUserDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _applicationService.UpdateUserAsync(model);

            return this.CreateResponse(response);
        }
        [Authorize]
        [HttpGet("BasicData/{id}")]
        public async Task<IActionResult> GetBasicData(string id)
        {
            var response = await _applicationService.GetUserDataAsync(id);
            return this.CreateResponse(response);
        }
        [Authorize]
        [HttpPost("ChangePassowrd")]
        public async Task<IActionResult> ChangePassword(ChangePasswordDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _applicationService.changePasswordAsync(model);
            return this.CreateResponse(response);
        }
        [Authorize]
        [HttpPost("ForgetPassword")]
        public async Task<IActionResult> ForgetPassword(ForgotPasswordDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _applicationService.ForgotPasswordAsync(model);
            return this.CreateResponse(response);
        }
        #endregion

    }
}
