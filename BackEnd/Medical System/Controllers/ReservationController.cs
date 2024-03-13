using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MS.Application.DTOs.Reservation;
using MS.Application.Helpers.Pagination;
using MS.Application.Helpers.Response;
using MS.Application.Interfaces;

namespace Medical_System.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class Reservation : ControllerBase
    {
        #region Constructor/props
        private readonly IReservationService _service;
        public Reservation(IReservationService service)
        {
            _service = service;
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
        [HttpPost("ClinicReservation")]
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
            try
            {
                // Retrieve the user ID from the token sent in the headers
                var userId = User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;

                if (userId == null)
                {
                    return BadRequest("User ID not found in token.");
                }

                // Retrieve reservations associated with the user ID
                var response = await _service.GetUserReservationsAsync(userId);

                return this.CreateResponse(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
        #endregion
    }
}