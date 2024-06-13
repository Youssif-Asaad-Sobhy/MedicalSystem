using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MS.Application.DTOs.ApplicationUser;
using MS.Application.DTOs.Document;
using MS.Application.Helpers.Pagination;
using MS.Application.Helpers.Response;
using MS.Application.Helpers.UserManagerExtensions;
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
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ApplicationUserController(IApplicationUserService applicationService, UserManager<ApplicationUser> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _applicationService = applicationService;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
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
        [Authorize(Roles="Admin")]
        [HttpPost]
        public async Task<IActionResult> CreateUserAsync([FromForm] CreateUserDto model)
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
        public async Task<IActionResult> PutSingleAsync([FromForm] UpdateUserDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _applicationService.UpdateUserAsync(model);

            return this.CreateResponse(response);
        }
        [Authorize]
        [HttpGet("BasicData")]
        public async Task<IActionResult> GetBasicData()
        {
            var userId = _userManager.GetCurrentUserId(_httpContextAccessor);
            if (userId == null)
            {
                return BadRequest("User ID not found in token.");
            }
            var response = await _applicationService.GetUserDataAsync(userId);
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
        [HttpGet("GetAllDiseaseOfUser")]
        public async Task<IActionResult> GetAllDiseaseOfUser()
        {
            var userId = _userManager.GetCurrentUserId(_httpContextAccessor);
            if (userId == null)
            {
                return BadRequest("User ID not found in token.");
            }
            var response = await _applicationService.GetAllUserDiseases(userId);
            return this.CreateResponse(response);
        }
        [Authorize(Roles ="Admin")]
        [HttpGet("Dashboard-GetAllUsers")]
        public async Task<IActionResult> GetAllUsers([FromQuery]PageFilter? filter,[FromQuery]string search=null)
        {
            var response = await _applicationService.GetAllUsers(filter,search);
            return this.SuccessCollection(response);
        }

        #endregion

    }
}
