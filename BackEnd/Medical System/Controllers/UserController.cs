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
        [HttpGet("{ID}")]
        public async Task<IActionResult> GetSingleClincAsync([FromRoute] string ID)
        {
            var response = await _applicationService.GetUserByIDAsync(ID);

            return this.CreateResponse(response);
        }


        [HttpDelete("{ID}")]
        public async Task<IActionResult> DeleteSingleAsync(string ID)
        {
            var response = await _applicationService.DeleteUserAsync(ID);

            return this.CreateResponse(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateClinicAsync([FromBody] CreateUserDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _applicationService.CreateUserAsync(model);

            return this.CreateResponse(response);
        }
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
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBasicData(string id)
        {
            var response = await _applicationService.GetUserDataAsync(id);
            return this.CreateResponse(response);
        }
        #endregion

    }
}
