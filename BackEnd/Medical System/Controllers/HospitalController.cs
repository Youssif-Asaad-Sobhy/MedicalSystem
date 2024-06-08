using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MS.Application.DTOs.Equipment;
using MS.Application.DTOs.Hospital;
using MS.Application.Helpers.Response;
using MS.Application.Interfaces;

namespace Medical_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class HospitalController : ControllerBase
    {
        #region Constructor/props
        private readonly IHospitalService _service;
        public HospitalController(IHospitalService service)
        {
            _service = service;
        }
        #endregion

        #region Methods
        [HttpGet("Get/{ID:int}")]
        public async Task<IActionResult> GetSingleAsync([FromRoute] int ID)
        {
            var response = await _service.GetHospitalAsync(ID);
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
            var response = await _service.DeleteHospitalAsync(ID);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("Post")]
        public async Task<IActionResult> CreateAsync([FromBody] CreateHospitalDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _service.CreateHospitalAsync(model);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }
        [Authorize(Roles = "Admin")]
        [HttpPut("Put")]
        public async Task<IActionResult> PutSingleAsync([FromBody] UpdateHospitalDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _service.UpdateHospitalAsync(model);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }
        #endregion
    }
}
