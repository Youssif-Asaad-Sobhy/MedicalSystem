using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MS.Application.DTOs.Hospital;
using MS.Application.DTOs.Disease;
using MS.Application.Helpers.Response;
using MS.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using MS.Application.Helpers.Pagination;

namespace Medical_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DiseaseController : ControllerBase
    {
        #region Constructor/props
        private readonly IDiseaseService _service;
        public DiseaseController(IDiseaseService service)
        {
            _service = service;
        }
        #endregion

        #region Methods
        [HttpGet("{ID:int}")]
        public async Task<IActionResult> GetSingleAsync([FromRoute] int ID)
        {
            var response = await _service.GetDiseaseAsync(ID);
            
            return this.CreateResponse(response);
        }
        
        [Authorize(Roles = "Admin")]
        [HttpDelete("{ID:int}")]
        public async Task<IActionResult> DeleteSingleAsync(int ID)
        {
            var response = await _service.DeleteDiseaseAsync(ID);
            
            return this.CreateResponse(response);
        }
        
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreateDiseaseDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _service.CreateDiseaseAsync(model);
            
            return this.CreateResponse(response);
        }
        [Authorize(Roles = "Admin")]
        [HttpPut]
        public async Task<IActionResult> PutSingleAsync([FromBody] UpdateDiseaseDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _service.UpdateDiseaseAsync(model);
            
            return this.CreateResponse(response);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var response = await _service.GetAllDiseasesAsync();

            return this.CreateResponse(response);
        }
        [HttpGet("paginated")]
        public async Task<IActionResult> GetAllDiseasesPaginatedAsync([FromQuery] string[]? filter, [FromQuery] PageFilter? pageFilter, [FromQuery] string? search = null)
        {
            var response = await _service.GetAllDiseaseAsync(filter, pageFilter, search);
            return Ok(response);
        }
        #endregion
    }
}