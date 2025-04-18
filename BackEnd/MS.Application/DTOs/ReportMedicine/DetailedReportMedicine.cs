using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace MS.Application.DTOs.ReportMedicine
{
    public class DetailedReportMedicine
    {
        public int ID { get; set; }
        public int ReportID { get; set; }
        public int MedicineTypeID { get; set; }
    }
}
