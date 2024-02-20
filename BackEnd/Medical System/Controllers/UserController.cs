using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MS.Application.DTOs.ApplicationUser;
using MS.Application.DTOs.Document;
using MS.Application.Helpers.Response;
using MS.Application.Interfaces;
using MS.Application.Services;

namespace Medical_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        #region Constructor/props
        private readonly IApplicationService _applicationService;

        public UserController(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }
        #endregion

        #region Methods
        [HttpGet("Get/{ID}")]
        public async Task<IActionResult> GetSingleClincAsync([FromRoute] string ID)
        {
            var response = await _applicationService.GetUserByIDAsync(ID);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }


        [HttpDelete("Delete/{ID}")]
        public async Task<IActionResult> DeleteSingleAsync(string ID)
        {
            var response = await _applicationService.DeleteUserAsync(ID);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }

        [HttpPost("Post")]
        public async Task<IActionResult> CreateClinicAsync([FromBody] CreateUserDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _applicationService.CreateUserAsync(model);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }
        [HttpPut("Put")]
        public async Task<IActionResult> PutSingleAsync([FromBody] UpdateUserDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _applicationService.UpdateUserAsync(model);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }
        #endregion

    }
}
