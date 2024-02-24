using System.ComponentModel.DataAnnotations;

namespace MS.Application.DTOs.Test
{
    public class CreateTestDto
    {
        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Name must be between 3 and 100 characters")]
        public string Name { get; set; }
    }
}
