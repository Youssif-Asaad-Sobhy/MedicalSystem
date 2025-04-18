using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MS.Application.DTOs.Equipment;
using MS.Data.Enums;

namespace MS.Application.DTOs.PlaceEquipment
{
    public class DetailedPlaceEquipment
    {
        public int ID { get; set; }
        public int EquipmentID { get; set; }
        public int EntityID { get; set; }
        public PlaceType PlaceType { get; set; }
        public DetailedEquipment Equipment { get; set; }
    }
}
