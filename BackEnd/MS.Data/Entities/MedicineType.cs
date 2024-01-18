using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Data.Entities
{
    public class MedicineType
    {
        ///ID	MedID	TypeID	Price	Description	SideEffects	Warning	ExpireDuration
        public int ID { get; set; }
        public int MedicineID { get; set; }
        public int TypeID { get; set; }
        public double Price {  get; set; }
        public string Description { get; set; }
        public string SideEffects { get; set; }
        public string Warning { get; set; }
        public DateTime ExpirationDuration { get; set; }
    }
}
