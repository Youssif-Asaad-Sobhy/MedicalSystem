
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Data.Entities
{
    public class OTP
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string UserID { get; set; }
        public ApplicationUser User { get; set; }
        public DateTime ExpirationTime { get; set; }
    }
}
