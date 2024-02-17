using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MS.Application.DTOs.Clinc;
using MS.Application.Interfaces;
using MS.Application.Models.Clinic;
using MS.Data.Entities;
using MS.Infrastructure.Repositories.UnitOfWork;

namespace Medical_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClinicController : ControllerBase
    {
        #region Constructor/props
        // there is error {unable to resolve I logger} 
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;
        private readonly IClinicService _clinicService;
        public ClinicController(IUnitOfWork unitOfWork, IClinicService clinicService, ILogger logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _clinicService = clinicService;
        }
        #endregion

        #region Methods
        [HttpGet("Get/{ClinicID:int}")]
        public async Task<IActionResult> GetSingleClincAsync([FromRoute] int ClinicID)
        {
            try
            {
                var response = await _clinicService.GetClinicAsync(ClinicID);
                if (!response.Succeeded)
                {
                    return NotFound(response.Message);
                }
                return Ok(response);

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
                var response = await _clinicService.DeleteClinicAsync(ClinicID);
                if (!response.Succeeded)
                {
                    return NotFound(response.Message);
                }
                return Ok(response);

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
        [HttpPut("Put/{ClinicID:int}")]
        public async Task<IActionResult> PutSingleAsync(ClinicDto model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var response = await _clinicService.UpdateClinicAsync(model);
                if (!response.Succeeded)
                {
                    return NotFound(response.Message);
                }
                return (IActionResult)response;
            }
            catch (Exception ex)
            {
                // Log the exception
                _logger.LogError($"An error occurred while processing the request: {ex}");

                return StatusCode(500, $"An error occurred while processing the request. Please try again or contact support.");
            }
        } 
        #endregion


    }
}
