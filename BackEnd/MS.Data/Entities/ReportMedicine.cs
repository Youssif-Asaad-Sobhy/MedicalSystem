using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Data.Entities
{
    public class ReportMedicine
    {
        public int ID { get; set; }
        public int ReportID { get; set; }
        public int MedTypeID { get; set; }
        public Report Report { get; set; }
        public MedicineType MedicineType { get; set; }
    }
}
