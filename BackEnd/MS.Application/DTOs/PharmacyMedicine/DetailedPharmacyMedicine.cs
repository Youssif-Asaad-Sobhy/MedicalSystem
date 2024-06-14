using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MS.Application.DTOs.MedicineType;
using MS.Application.DTOs.Pharmacy;
using MS.Application.DTOs.Type;

namespace MS.Application.DTOs.PharmacyMedicine
{
    public class DetailedPharmacyMedicine
    {
        public int ID { get; set; }
        public int PharmacyID { get; set; }
        public int MedicineTypeID { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public DetailedPharmacy Pharmacy { get; set; }
        public DetailedMedicineType MedicineType { get; set; }
    }
}
