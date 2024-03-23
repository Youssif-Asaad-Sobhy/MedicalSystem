using System.ComponentModel.DataAnnotations;

namespace MS.Application.DTOs.TestLab
{
    public class CreateTestLabDto
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "TestLabID must be a positive integer")]
        public int TestLabID { get; set; }

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
