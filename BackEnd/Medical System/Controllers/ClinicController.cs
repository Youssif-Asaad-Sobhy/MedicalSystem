using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MS.Application.DTOs.Clinc;
using MS.Application.Helpers.Filters;
using MS.Application.Helpers.Response;
using MS.Application.Interfaces;
using MS.Application.Services;
using MS.Data.Entities;
using MS.Infrastructure.Repositories.UnitOfWork;
using Newtonsoft.Json;
using System.Reflection.Metadata.Ecma335;

namespace Medical_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClinicController : ControllerBase
    {
        #region Constructor/props
        private readonly IClinicService _clinicService;
        public ClinicController(IClinicService clinicService)
        {
            _clinicService = clinicService;
        }
        #endregion

        #region Methods
        [HttpGet("{ClinicID:int}")]
        public async Task<IActionResult> GetSingleClincAsync([FromRoute] int ClinicID)
        {
            var response = await _clinicService.GetClinicAsync(ClinicID);

            return this.CreateResponse(response);
       
        }


        [HttpDelete("{ClinicID:int}")]
        public async Task<IActionResult> DeleteSingleAsync(int ClinicID)
        {
            var response = await _clinicService.DeleteClinicAsync(ClinicID);
            return this.CreateResponse(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateClinicAsync([FromQuery] CreateClinicDto model) //same comment as below
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _clinicService.CreateClinicAsync(model);
            return this.CreateResponse(response);
        }
        [HttpPut]
        public async Task<IActionResult> PutSingleAsync([FromQuery]UpdateClinicDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _clinicService.UpdateClinicAsync(model);
            return this.CreateResponse(response);
        }

        [HttpGet("GetAllClinicsWthDeptId/{DepartmentId:int}")]
        public async Task<IActionResult> GetAllClinicsWithDepartmentIdAsync(int DepartmentId)
        {
            var response = await _clinicService.GetAllClinicsWithDepartmentIdAsync(DepartmentId);
           
            return this.CreateResponse(response);
        }
        [HttpGet("All-Clinics")]
        public async Task<IActionResult> GetAllAsync([FromQuery] string[]?filter)
        {
            var response = await _clinicService.GetAllClinicsAsync(filter);
            return this.CreateResponse(response);
        }
        #endregion


    }
}
