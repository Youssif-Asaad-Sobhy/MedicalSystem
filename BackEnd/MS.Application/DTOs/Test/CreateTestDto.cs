using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace MS.Application.DTOs.Test
{
    public class CreateTestDto
    {
        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Name must be between 3 and 100 characters")]
        public string Name { get; set; }
        [RegularExpression(@"^([A-Za-z0-9+/]{4})*([A-Za-z0-9+/]{3}=|[A-Za-z0-9+/]{2}==)?$", ErrorMessage = "Invalid Base64 encoded photo")]
        public IFormFile Photo { get; set; }
    }
}
