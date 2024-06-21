using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MS.Application.DTOs.Hospital;
using MS.Application.DTOs.Lab;
using MS.Application.Helpers.Pagination;
using MS.Application.Helpers.Response;
using MS.Application.Interfaces;

namespace Medical_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LabController : ControllerBase
    {
        #region Constructor/props
        private readonly ILabService _service;
        public LabController(ILabService service)
        {
            _service = service;
        }
        #endregion

        #region Methods
        [HttpGet("Get/{ID:int}")]
        public async Task<IActionResult> GetSingleAsync([FromRoute] int ID)
        {
            var response = await _service.GetLabAsync(ID);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }


        [Authorize(Roles = "Admin")]
        [HttpDelete("Delete/{ID:int}")]
        public async Task<IActionResult> DeleteSingleAsync(int ID)
        {
            var response = await _service.DeleteLabAsync(ID);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("Post")]
        public async Task<IActionResult> CreateAsync([FromBody] CreateLabDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _service.CreateLabAsync(model);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }
        [Authorize(Roles = "Admin")]
        [HttpPut("Put")]
        public async Task<IActionResult> PutSingleAsync([FromBody] UpdateLabDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _service.UpdateLabAsync(model);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _service.GetLabsAsync();
            return this.CreateResponse(response);
        }
        [HttpGet("paginated")]
        public async Task<IActionResult> GetAllLabAsync([FromQuery] string[]? filter, [FromQuery] PageFilter? pageFilter, [FromQuery] string? search = null)
        {
            var response = await _service.GetAllLabAsync(filter, pageFilter, search);
            return Ok(response);
        }
        #endregion
    }
}
