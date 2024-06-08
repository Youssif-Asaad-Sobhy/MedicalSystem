using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MS.Application.DTOs.Pharmacy;
using MS.Application.DTOs.PharmacyMedicine;
using MS.Application.Helpers.Response;
using MS.Application.Interfaces;

namespace Medical_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PharmacyController : ControllerBase
    {
        #region Constructor/props
        private readonly IPharmacyService _service;
        public PharmacyController(IPharmacyService service)
        {
            _service = service;
        }
        #endregion

        #region Methods
        [HttpGet("Get/{ID:int}")]
        public async Task<IActionResult> GetSingleAsync([FromRoute] int ID)
        {
            var response = await _service.GetPharmacyAsync(ID);
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
            var response = await _service.DeletePharmacyAsync(ID);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("Post")]
        public async Task<IActionResult> CreateAsync([FromBody] CreatePharmacyDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _service.CreatePharmacyAsync(model);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }
        [Authorize(Roles = "Admin")]
        [HttpPut("Put")]
        public async Task<IActionResult> PutSingleAsync([FromBody] UpdatePharmacyDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _service.UpdatePharmacyAsync(model);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }
        #endregion
    }
}
