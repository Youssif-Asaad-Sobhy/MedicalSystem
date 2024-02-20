using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MS.Application.DTOs.Document;
using MS.Application.DTOs.EntityAuth;
using MS.Application.Helpers.Response;
using MS.Application.Interfaces;

namespace Medical_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntityAuthController : ControllerBase
    {
        #region Constructor/props
        private readonly IEntityAuthService _entityAuthService;
        public EntityAuthController(IEntityAuthService entityAuthService)
        {
            _entityAuthService = entityAuthService;
        }
        #endregion

        #region Methods
        [HttpGet("Get/{ID:int}")]
        public async Task<IActionResult> GetSingleAsync([FromRoute] int ID)
        {
            var response = await _entityAuthService.GetEntityAuthAsync(ID);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }


        [HttpDelete("Delete/{ID:int}")]
        public async Task<IActionResult> DeleteSingleAsync(int ID)
        {
            var response = await _entityAuthService.DeleteEntityAuthAsync(ID);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }

        [HttpPost("Post")]
        public async Task<IActionResult> CreateAsync([FromBody] CreateEntityAuthDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _entityAuthService.CreateEntityAuthAsync(model);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }
        [HttpPut("Put")]
        public async Task<IActionResult> PutSingleAsync([FromBody] UpdateEntityAuthDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _entityAuthService.UpdateEntityAuthAsync(model);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }
        #endregion
    }
}
