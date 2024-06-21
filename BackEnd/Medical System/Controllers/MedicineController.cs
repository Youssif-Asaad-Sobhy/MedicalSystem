using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MS.Application.DTOs.Lab;
using MS.Application.DTOs.Medicine;
using MS.Application.Helpers.Pagination;
using MS.Application.Helpers.Response;
using MS.Application.Interfaces;

namespace Medical_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MedicineController : ControllerBase
    {
        #region Constructor/props
        private readonly IMedicineService _service;
        public MedicineController(IMedicineService service)
        {
            _service = service;
        }
        #endregion

        #region Methods
        [HttpGet("Get/{ID:int}")]
        public async Task<IActionResult> GetSingleAsync([FromRoute] int ID)
        {
            var response = await _service.GetMedicineAsync(ID);
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
            var response = await _service.DeleteMedicineAsync(ID);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("Post")]
        public async Task<IActionResult> CreateAsync([FromBody] CreateMedicineDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _service.CreateMedicineAsync(model);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }
    
        [HttpPost("AddMedicine")]
        public async Task<IActionResult> AddMedicine([FromBody] AddMedicineDto medicineDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var response = await _service.AddMedicineAsync(medicineDTO);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }
        [Authorize(Roles = "Admin")]
        [HttpPut("Put")]
        public async Task<IActionResult> PutSingleAsync([FromBody] UpdateMedicineDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _service.UpdateMedicineAsync(model);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }
        [HttpGet("paginated")]
        public async Task<IActionResult> GetAllMedicineAsync([FromQuery] string[]? filter, [FromQuery] PageFilter? pageFilter, [FromQuery] string? search = null)
        {
            var response = await _service.GetAllMedicineAsync(filter, pageFilter, search);
            return Ok(response);
        }
        [HttpGet("GetMedicineData")]
        public async Task<IActionResult> GetMedicineByIDAsync([FromQuery]int id,[FromQuery] string[]? filter, [FromQuery] PageFilter? pageFilter, [FromQuery] string? search = null)
        {
            var response = await _service.GetMedicineByIDAsync(id,filter, pageFilter, search);
            return Ok(response);
        }
        #endregion
    }
}
