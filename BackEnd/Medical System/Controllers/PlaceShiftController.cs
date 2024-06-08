using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MS.Application.DTOs.PlaceShift;
using MS.Application.Helpers.Response;
using MS.Application.Interfaces;

namespace Medical_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PlaceShift : ControllerBase
    {
        #region Constructor/props
        private readonly IPlaceShiftService _service;
        public PlaceShift(IPlaceShiftService service)
        {
            _service = service;
        }
        #endregion

        #region Methods
        [HttpGet("Get/{ID:int}")]
        public async Task<IActionResult> GetSingleAsync([FromRoute] int ID)
        {
            var response = await _service.GetPlaceShiftAsync(ID);
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
            var response = await _service.DeletePlaceShiftAsync(ID);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("Post")]
        public async Task<IActionResult> CreateAsync([FromBody] CreatePlaceShiftDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _service.CreatePlaceShiftAsync(model);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }
        [Authorize(Roles = "Admin")]
        [HttpPut("Put")]
        public async Task<IActionResult> PutSingleAsync([FromBody] UpdatePlaceShiftDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _service.UpdatePlaceShiftAsync(model);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }
        #endregion
    }
}