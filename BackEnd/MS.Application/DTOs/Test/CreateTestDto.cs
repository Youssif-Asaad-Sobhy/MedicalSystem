using System.ComponentModel.DataAnnotations;

namespace MS.Application.DTOs.Test
{
    public class CreateTestDto
    {
        [Required]
        public string Name { get; set; }
    }
}
