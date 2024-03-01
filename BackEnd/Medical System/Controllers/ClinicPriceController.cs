using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MS.Application.DTOs.Clinc;
using MS.Application.DTOs.ClinicPrice;
using MS.Application.Helpers.Response;
using MS.Application.Interfaces;
using MS.Application.Services;

namespace Medical_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClinicPriceController : ControllerBase
    {
        #region Constructor/props
        private readonly IPlacePriceService _clinicPriceService;
        public ClinicPriceController(IPlacePriceService clinicPriceService)
        {
            _clinicPriceService=clinicPriceService;
        }
        #endregion
        #region Method
        [HttpGet("get/{ID:int}")]
        public async Task<IActionResult> GetSingleClincAsync([FromRoute] int ID)
        {
            var response = await _clinicPriceService.GetClinicPriceAsync(ID);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }
        [HttpDelete("Delete/{ID:int}")]
        public async Task<IActionResult> DeleteSingleAsync([FromRoute]int ID)
        {
            var response = await _clinicPriceService.GetClinicPriceAsync(ID);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }

        [HttpPost("Post")]
        public async Task<IActionResult> CreateClinicAsync([FromBody] CreateClinicPriceDto model) 
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _clinicPriceService.CreateClinicPriceAsync(model);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }

        [HttpPut("Put")]
        public async Task<IActionResult> PutSingleAsync([FromBody]UpdateClinicPriceDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _clinicPriceService.UpdateClinicPriceAsync(model);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }
        #endregion
    }
}
