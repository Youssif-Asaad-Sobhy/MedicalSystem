using System.ComponentModel.DataAnnotations;

namespace MS.Application.DTOs.Test
{
    public class UpdateTestDto
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "ID must be a positive integer")]
        public int ID { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Name must be between 3 and 100 characters")]
        public string Name { get; set; }
    }
}
