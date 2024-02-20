using System.ComponentModel.DataAnnotations;

namespace MS.Application.DTOs.Test
{
    public class UpdateTestDto
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
