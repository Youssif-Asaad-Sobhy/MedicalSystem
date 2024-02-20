using MS.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.DTOs.MedicineType
{
    internal class UpdateMedicineTypeDto
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public int MedicineID { get; set; }
        [Required]
        public int TypeID { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string SideEffects { get; set; }
        [Required]
        public string Warning { get; set; }
        [Required]
        public DateTime ExpirationDate { get; set; }
    }
}
