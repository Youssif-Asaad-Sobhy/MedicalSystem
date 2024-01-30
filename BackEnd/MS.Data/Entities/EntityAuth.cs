using MS.Data.Enums;
using MS.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Data.Entities
{
    public class EntityAuth
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public PlaceType PlaceType { get; set; }
        public int EntityID {  get; set; }
    }
}
