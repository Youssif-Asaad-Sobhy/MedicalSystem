using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MS.Application.DTOs.Medicine;
using MS.Application.DTOs.Type;

namespace MS.Application.DTOs.MedicineType
{
    public class DetailedMedicineType
    {
        public int ID { get; set; }
        public int MedicineID { get; set; }
        public int TypeID { get; set; }
        public string Description { get; set; }
        public string SideEffects { get; set; }
        public string Warning { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public DetailedMedicine Medicine { get; set; }
        public DetailedType Types { get; set; }
    }
}
