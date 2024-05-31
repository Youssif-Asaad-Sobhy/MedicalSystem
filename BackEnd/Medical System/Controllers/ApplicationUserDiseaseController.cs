using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MS.Application.DTOs.Hospital;
using MS.Application.DTOs.ApplicationUserDisease;
using MS.Application.Helpers.Response;
using MS.Application.Interfaces;

namespace Medical_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUserDiseaseController : ControllerBase
    {
        #region Constructor/props
        private readonly IApplicationUserDiseaseService _service;
        public ApplicationUserDiseaseController(IApplicationUserDiseaseService service)
        {
            _service = service;
        }
        #endregion

        #region Methods
        [HttpGet("{ID:int}")]
        public async Task<IActionResult> GetSingleUserDiseseAsync([FromRoute] int ID)
        {
            var response = await _service.GetApplicationUserDiseaseAsync(ID);
           
            return this.CreateResponse(response);
        }

        [HttpDelete("{ID:int}")]
        public async Task<IActionResult> DeleteSingleAsync(int ID)
        {
            var response = await _service.DeleteApplicationUserDiseaseAsync(ID);
            
            return this.CreateResponse(response);
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreateApplicationUserDiseaseDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _service.CreateApplicationUserDiseaseAsync(model);
            
            return this.CreateResponse(response);
        }
        [HttpPut]
        public async Task<IActionResult> PutSingleAsync([FromBody] UpdateApplicationUserDiseaseDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _service.UpdateApplicationUserDiseaseAsync(model);
            
            return this.CreateResponse(response);
        }
        #endregion
    }
}