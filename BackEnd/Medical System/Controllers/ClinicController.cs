﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MS.Application.DTOs.Clinc;
using MS.Application.Helpers.Response;
using MS.Application.Interfaces;
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
        private readonly IClinicService _clinicService;
        public ClinicController( IClinicService clinicService)
        {
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

        [HttpPost("Post")]
        public async Task<IActionResult> CreateClinicAsync([FromBody]CreateClinicDto model) //same comment as below
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response=await _clinicService.CreateClinicAsync(model);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }
        [HttpPut("Put")]
        public async Task<IActionResult> PutSingleAsync(UpdateClinicDto model)
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

        [HttpGet("GetAllClinics/{DepartmentId:int}")]
        public async Task<IActionResult> GetAllClinicsWithDepartmentIdAsync(int DepartmentId)
        {
            var response = await _clinicService.GetAllClinicsWithDepartmentIdAsync(DepartmentId);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }


        #endregion


    }
}
