using MS.Data.Enums;
using MS.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Data.Entities
{
    public class Lab : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public LabType Type { get; set; }
        public int HospitalID { get; set; }
        public Hospital hospital { get; set; }
        public ICollection<TestLab> testLabs { get; set; }
        public ICollection<PlaceShift> PlaceShifts { get; set; }
        public ICollection<PlaceEquipment> PlaceEquipment { get; set; }
        public ICollection<Reservation> Reservations { get; set; }


    }
}
