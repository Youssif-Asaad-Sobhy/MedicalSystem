using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MS.Application.DTOs.Types;
using MS.Application.Helpers.Response;
using MS.Application.Interfaces;

namespace Medical_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Type : ControllerBase
    {
        #region Constructor/props
        private readonly ITypeService _service;
        public Type(ITypeService service)
        {
            _service = service;
        }
        #endregion

        #region Methods
        [HttpGet("Get/{ID:int}")]
        public async Task<IActionResult> GetSingleAsync([FromRoute] int ID)
        {
            var response = await _service.GetTypeAsync(ID);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }


        [HttpDelete("Delete/{ID:int}")]
        public async Task<IActionResult> DeleteSingleAsync(int ID)
        {
            var response = await _service.DeleteTypeAsync(ID);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }

        [HttpPost("Post")]
        public async Task<IActionResult> CreateAsync([FromBody] CreateTypeDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _service.CreateTypeAsync(model);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }
        [HttpPut("Put")]
        public async Task<IActionResult> PutSingleAsync([FromBody] UpdateTypeDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _service.UpdateTypeAsync(model);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }
        #endregion
    }
}