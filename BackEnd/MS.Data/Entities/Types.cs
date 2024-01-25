using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Data.Entities
{
    public class Types
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<MedicineType> MedicineTypes { get; set; }
    }
}
