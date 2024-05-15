using MS.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Data.Entities
{
    public class Clinic : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DepartmentID { get; set; }
        public string? Description { get; set; }
        public int PhotoID { get; set; }
        public Attachment Photo { get; set; }
        public Department Department { get; set; }
        public ICollection<PlacePrice> PlacePrices { get; set; }
        public ICollection<PlaceShift> PlaceShifts { get; set; }
        public ICollection<PlaceEquipment> PlaceEquipment { get; set; }
        public ICollection<Reservation> Reservations { get; set; }

    }
}
