using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.DTOs.Document
{
    public class CreateDoctDto
    {
        [Required]
        public byte[] Content { get; set; }
        [Required]
        public int ReportID { get; set; }
    }
}
