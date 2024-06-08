using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MS.Application.DTOs.Clinc;
using MS.Application.DTOs.ClinicPrice;
using MS.Application.Helpers.Response;
using MS.Application.Interfaces;
using MS.Application.Services;
using MS.Data.Enums;

namespace Medical_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PlacePriceController : ControllerBase
    {
        #region Constructor/props
        private readonly IPlacePriceService _pricePriceService;
        public PlacePriceController(IPlacePriceService placePriceService)
        {
            _pricePriceService=placePriceService;
        }
        #endregion
        #region Method
        [HttpGet("{ID:int}")]
        public async Task<IActionResult> GetSingleAsync([FromRoute] int ID)
        {
            var response = await _pricePriceService.GetPlacePriceAsync(ID);
            return this.CreateResponse(response);
        }
        [Authorize(Roles = "Admin")]
        [HttpDelete("{ID:int}")]
        public async Task<IActionResult> DeleteSingleAsync([FromRoute]int ID)
        {
            var response = await _pricePriceService.GetPlacePriceAsync(ID);
            return this.CreateResponse(response);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost()]
        public async Task<IActionResult> CreateClinicAsync([FromBody] CreatePlacePriceDto model) 
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _pricePriceService.CreatePlacePriceAsync(model);
            return this.CreateResponse(response);
        }

        [Authorize(Roles = "Admin")]
        [HttpPut()]
        public async Task<IActionResult> PutSingleAsync([FromBody]UpdatePlacePriceDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _pricePriceService.UpdatePlacePriceAsync(model);
            return this.CreateResponse(response);
        }
        [HttpGet("All-Place-Prices")]
        public async Task<IActionResult> GetAllPlacePrices([FromQuery]PlaceType placeType,[FromQuery]int placeId)
        { 
            var response = await _pricePriceService.GetAllPlacePricesAsync(placeType, placeId);
            return this.CreateResponse(response);
        }
        #endregion
    }
}
