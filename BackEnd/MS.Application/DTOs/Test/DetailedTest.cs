using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace MS.Application.DTOs.Test
{
    public class DetailedTest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int PhotoID { get; set; }
        public Data.Entities.Attachment Photo { get; set; }
    }
}
