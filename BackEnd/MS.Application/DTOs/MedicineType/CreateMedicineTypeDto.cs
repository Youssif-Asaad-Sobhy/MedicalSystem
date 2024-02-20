using System;
using System.ComponentModel.DataAnnotations;

namespace MS.Application.DTOs.MedicineType
{
    public class CreateMedicineTypeDto
    {
        [Required]
        public int MedicineID { get; set; }

        [Required]
        public int TypeID { get; set; }

        public string Description { get; set; }

        public string SideEffects { get; set; }

        public string Warning { get; set; }

        [Required]
        public DateTime ExpirationDate { get; set; }
    }
}
