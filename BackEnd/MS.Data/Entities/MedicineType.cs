using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Data.Entities
{
    public class MedicineType
    {
        public int ID { get; set; }
        public int MedicineID { get; set; }
        public int TypeID { get; set; }
        public string Description { get; set; }
        public string SideEffects { get; set; }
        public string Warning { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public Medicine Medicine { get; set; }
        public Types Types { get; set; }
        public ICollection<PharmacyMedicine> PharmacyMedicines { get; set; }
        public ICollection<ReportMedicine> ReportMedicines { get; set; }
    }
}
