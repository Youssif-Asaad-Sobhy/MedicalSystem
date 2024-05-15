using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Data.Entities
{
    public class PharmacyMedicine
    {
        public int ID { get; set; }
        public int PharmacyID { get; set; }
        public int MedicineTypeID { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public Pharmacy Pharmacy { get; set; }
        public MedicineType MedicineType { get; set; }
    }
}
