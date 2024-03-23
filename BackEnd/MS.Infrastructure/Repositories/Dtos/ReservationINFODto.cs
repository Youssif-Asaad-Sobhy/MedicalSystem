using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Infrastructure.Repositories.Dtos
{
    public class ReservationINFODto
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string Nid { get; set; }
        public string PlaceName { get; set; }
        public double Price { get; set; }
        public DateTime Time { get; set; }
    }


}
