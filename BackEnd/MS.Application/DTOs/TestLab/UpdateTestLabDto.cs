using System.ComponentModel.DataAnnotations;

namespace MS.Application.DTOs.TestLab
{
    public class UpdateTestLabDto
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "ID must be a positive integer")]
        public int ID { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "TestID must be a positive integer")]
        public int TestID { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "LabID must be a positive integer")]
        public int LabID { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(0, double.MaxValue, ErrorMessage = "Price must be a positive number")]
        public double Price { get; set; }

        [Required]
        [MaxLength(1000, ErrorMessage = "Description cannot exceed 1000 characters")]
        public string Description { get; set; }
    }
}
