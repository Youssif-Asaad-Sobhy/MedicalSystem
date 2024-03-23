using Azure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MS.Application.DTOs.Reservation;
using MS.Application.Helpers.Pagination;
using MS.Application.Helpers.Response;
using MS.Application.Helpers.UserManagerExtensions;
using MS.Application.Interfaces;
using MS.Data.Entities;
using MS.Data.Enums;
using MS.Infrastructure.Repositories.Dtos;
using MS.Infrastructure.Repositories.Repository.RepoInterfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Medical_System.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class Reservation : ControllerBase
    {
        #region Constructor/props
        private readonly IReservationService _service;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public Reservation(IReservationService service, UserManager<ApplicationUser> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _service = service;
            _userManager = userManager;
        }
        #endregion

        #region Methods
        [HttpGet("Get/{ID:int}")]
        public async Task<IActionResult> GetSingleAsync([FromRoute] int ID)
        {
            var response = await _service.GetReservationAsync(ID);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }


        [HttpDelete("Delete/{ID:int}")]
        public async Task<IActionResult> DeleteSingleAsync(int ID)
        {
            var response = await _service.DeleteReservationAsync(ID);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }
        [HttpPost("UserReservation")]
        public async Task<IActionResult> CreateAsync([FromBody] PlaceReservationDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _service.PlaceReservationAsync(model);
            return this.CreateResponse(response);
        }
        [HttpPut("Put")]
        public async Task<IActionResult> PutSingleAsync([FromBody] UpdateReservationDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _service.UpdateReservationAsync(model);
            if (!response.Succeeded)
            {
                return this.CreateResponse(response);
            }
            return this.CreateResponse(response);
        }
        [HttpGet("All-Reservations")]
        public async Task<IActionResult> GetTodayReservations([FromQuery]PageFilter filter)
        {
            var response = await _service.TodaysReservationsAsync(filter);
            return this.SuccessCollection(response);
        }

        [HttpGet("UserReservations")]
        public async Task<IActionResult> GetUserReservationsAsync()
        {
            var userId = _userManager.GetCurrentUserId(_httpContextAccessor);
            if (userId == null)
            {
                return BadRequest("User ID not found in token.");
            }
            var response = await _service.GetUserReservationsAsync(userId);
            return this.CreateResponse(response);
        }

        [HttpGet("PlaceReservation")]
        public async Task <IActionResult>GetUserPlace([FromQuery]int placeID,[FromQuery]PlaceType placeType)
        {
            var result = await _service.GetUsersByPlace(placeID, placeType);
            return this.CreateResponse(result);


        }

        #endregion
    }
}