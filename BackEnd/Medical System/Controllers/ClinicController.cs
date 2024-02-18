﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MS.Application.Models.Clinic;
using MS.Data.Entities;
using MS.Infrastructure.Repositories.UnitOfWork;

namespace Medical_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClinicController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;

        public ClinicController(IUnitOfWork unitOfWork, ILogger logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }
        [HttpGet("Get/{ClinicID:int}")]
        public async Task<IActionResult> GetSingleClincAsync(int ClinicID)
        {
            try
            {
                var clinic = await _unitOfWork.Clinincs.GetByIdAsync(ClinicID);

                if (clinic == null)
                {
                    return NotFound($"Clinic with ID {ClinicID} not found.");
                }

                return Ok(clinic);
            }
            catch (Exception ex)
            {
                // Log the exception
                _logger.LogError($"An error occurred while processing the request: {ex.Message}");

                return StatusCode(500, $"An error occurred while processing the request:{ex.Message}");
            }
        }

        // almost done 
        [HttpDelete("Delete/{ClinicID:int}")]
        public async Task<IActionResult> DeleteSingleAsync(int ClinicID)
        {
            try
            {
                var clinicToDelete = await _unitOfWork.Clinincs.GetByIdAsync(ClinicID);

                if (clinicToDelete == null)
                {
                    return NotFound($"Clinic with ID {ClinicID} not found.");
                }

                await _unitOfWork.Clinincs.DeleteAsync(clinicToDelete);

                return NoContent();
            }
            catch (Exception ex)
            {
                // Log the exception
                _logger.LogError($"An error occurred while processing the request: {ex}");
                //return to endpoint
                return StatusCode(500, $"An error occurred while processing the request: {ex.Message}");
            }
        }

        // i think done 
        [HttpPost("Post")]
        public async Task PostSingleAsync([FromBody]ClinicModel model) //same comment as below
        {
            Clinic clinic = new Clinic() {
                DepartmentID = model.DepartmentID,
                Name=model.Name
            };
            await _unitOfWork.Clinincs.AddAsync(clinic);
        }

        //done
        [HttpPut("Put")]
        public async Task<IActionResult> PutSingleAsync([FromBody]ClinicModel model) // why not using dto bro
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                if (model is null)
                {
                    return BadRequest("Please Enter correct ID");
                }
                Clinic OldClinic = await _unitOfWork.Clinincs.GetByIdAsync(model.ID);

                Clinic clinic = new Clinic()
                {
                  //  ID = model.ID, //u can not addin id cuz autogenerated
                   DepartmentID=model.DepartmentID,
                    Name = model.Name,
                };

                await _unitOfWork.Clinincs.UpdateAsync(clinic);

                return NoContent(); // 204 No Content on successful update
            }
            catch (Exception ex)
            {
                // Log the exception
                _logger.LogError($"An error occurred while processing the request: {ex}");

                return StatusCode(500, $"An error occurred while processing the request. Please try again or contact support.");
            }
        }


    }
}
