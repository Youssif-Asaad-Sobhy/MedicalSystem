using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace MS.Application.DTOs.Report
{
    public class DetailedReport
    {
        public int ID { get; set; }
        public DateTime Time { get; set; }
        public string Description { get; set; }
        public string UserID { get; set; }
        public string DoctorID { get; set; }

    }
}
