using MS.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.DTOs.MedicineType
{
    public class UpdateMedicineTypeDto
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public int MedicineID { get; set; }

        [Required]
        public int TypeID { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(500)]
        public string SideEffects { get; set; }
        
        [StringLength(500)]
        public string Warning { get; set; }
        public DateTime? ExpirationDate { get; set; }
    }
}
