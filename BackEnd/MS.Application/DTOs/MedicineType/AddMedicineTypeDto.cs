using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.DTOs.Medicine
{
    public class AddMedicineTypeDto
    {
        public int MedicineID { get; set; }
        public int TypeID { get; set; }
        public string Description { get; set; }
        public string SideEffects { get; set; }
        public string Warning { get; set; }
        public DateTime? ExpireDate { get;set; }
        public string MedicineName { get; set; }
        public string TypeName { get;set; }
    }
}