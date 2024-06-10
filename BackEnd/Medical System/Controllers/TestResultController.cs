using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MS.Application.DTOs.Hospital;
using MS.Application.DTOs.TestResult;
using MS.Application.Helpers.Response;
using MS.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using MS.Data.Entities;
using MS.Application.Helpers.UserManagerExtensions;

namespace Medical_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TestResultController : ControllerBase
    {
        #region Constructor/props
        private readonly ITestResultService _service;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public TestResultController(ITestResultService service, UserManager<ApplicationUser> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _service = service;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }
        #endregion

        #region Methods
        [HttpGet("{ID:int}")]
        public async Task<IActionResult> GetSingleTestResultAsync([FromRoute] int ID)
        {
            var response = await _service.GetTestResultAsync(ID);
           
            return this.CreateResponse(response);
        }

        [HttpDelete("{ID:int}")]
        public async Task<IActionResult> DeleteSingleAsync(int ID)
        {
            var response = await _service.DeleteTestResultAsync(ID);
            
            return this.CreateResponse(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromQuery] CreateTestResultDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _service.CreateTestResultAsync(model);
            
            return this.CreateResponse(response);
        }
        [HttpPut]
        public async Task<IActionResult> PutSingleAsync([FromQuery] UpdateTestResultDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _service.UpdateTestResultAsync(model);
            
            return this.CreateResponse(response);
        }
        [HttpGet("All-Test-Results")]
        public async Task<IActionResult> GetAllTestResultsAsync()
        {
            var userId = _userManager.GetCurrentUserId(_httpContextAccessor);
            if (userId == null)
            {
                return BadRequest("User ID not found in token.");
            }
            var response = await _service.GetAllTestResultAsync(userId);
            return this.CreateResponse(response);
        }
        #endregion
    }
}
