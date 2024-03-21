using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.DTOs.Reservation
{
    public class PlaceUserInClinicDto
    {
        public int ClinicId { get; set; }
        public string UserId { get; set; }
        [Description("Has default Value of Now")]
        public DateTime ReservationDate { get; set; } = DateTime.Now;
    }
}
