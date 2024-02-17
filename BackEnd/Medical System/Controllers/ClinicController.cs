using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MS.Application.DTOs.Clinc;
using MS.Application.Helpers.Response;
using MS.Application.Interfaces;
using MS.Application.Models.Clinic;
using MS.Data.Entities;
using MS.Infrastructure.Repositories.UnitOfWork;
using System.Reflection.Metadata.Ecma335;

namespace Medical_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClinicController : ControllerBase
    {
        #region Constructor/props
        private readonly IUnitOfWork _unitOfWork;
        private readonly IClinicService _clinicService;
        public ClinicController(IUnitOfWork unitOfWork, IClinicService clinicService)
        {
            _unitOfWork = unitOfWork;
            _clinicService = clinicService;
        }
        #endregion

        #region Methods
        [HttpGet("Get/{ClinicID:int}")]
        public async Task<IActionResult> GetSingleClincAsync([FromRoute] int ClinicID)
        {
            var response = await _clinicService.GetClinicAsync(ClinicID);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }

        // almost done 
        [HttpDelete("Delete/{ClinicID:int}")]
        public async Task<IActionResult> DeleteSingleAsync(int ClinicID)
        {
            var response = await _clinicService.DeleteClinicAsync(ClinicID);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }

        // i think done 
        [HttpPost("Post")]
        public async Task CreateClinicAsync([FromBody]ClinicModel model) //same comment as below
        {
            Clinic clinic = new Clinic() {
                DepartmentID = model.DepartmentID,
                Name=model.Name
            };
            await _unitOfWork.Clinincs.AddAsync(clinic);
        }
        [HttpPut("Put/{ClinicID:int}")]
        public async Task<IActionResult> PutSingleAsync(ClinicDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _clinicService.UpdateClinicAsync(model);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        } 
        #endregion


    }
}
