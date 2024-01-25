using MS.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Data.Entities
{
    public class Pharmacy : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int HospitalID { get; set; }
        public Hospital Hospital { get; set; }
        public ICollection<PlaceShift> PlaceShifts { get; set; }
        public ICollection<PharmacyMedicine> PharmacyMedicines { get; set; }
        public ICollection<PlaceEquipment> PlaceEquipments { get; set; }


    }
}
