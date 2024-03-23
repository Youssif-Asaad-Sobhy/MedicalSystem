using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Infrastructure.Repositories.Dtos
{
    public class GetAllcurrentReservationDto
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string Nid { get; set; }
        public DateTime BirthDate { get; set; }
        public string SerialNumber { get; set; }
    }
}
