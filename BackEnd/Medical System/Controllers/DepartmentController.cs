using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MS.Application.DTOs.Clinc;
using MS.Application.DTOs.Department;
using MS.Application.Helpers.Response;
using MS.Application.Interfaces;
using MS.Application.Services;
using Newtonsoft.Json;

namespace Medical_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DepartmentController : ControllerBase
    {

        #region Constructor/props
        private readonly IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
        #endregion

        #region Methods
        [HttpGet("{ID:int}")]
        public async Task<IActionResult> GetSingleAsync([FromRoute] int ID)
        {
            var response = await _departmentService.GetDepartmentByIDAsync(ID);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }
        [Authorize(Roles = "Admin")]
        [HttpDelete("{ID:int}")]
        public async Task<IActionResult> DeleteSingleAsync(int ID)
        {
            var response = await _departmentService.DeleteDepartmentAsync(ID);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreateDeptDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _departmentService.CreateDepartmentAsync(model);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }
        [Authorize(Roles = "Admin")]
        [HttpPut]
        public async Task<IActionResult> PutSingleAsync(UpdateDeptDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _departmentService.UpdateDepartmentAsync(model);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }
        [HttpGet("All-Departments")]
        public async Task<IActionResult> GetAllAsync([FromQuery]string[]?filter)
        {
            var response = await _departmentService.GetAllDepartmentsAsync(filter);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }
        #endregion
    }
}
