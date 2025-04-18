using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MS.Application.DTOs.Lab;
using MS.Application.DTOs.Test;

namespace MS.Application.DTOs.TestLab
{
    public class DetailedTestLab
    {
        public int ID { get; set; }
        public int TestID { get; set; }
        public int LabID { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public DetailedLab Lab { get; set; }
        public DetailedTest Test { get; set; }
    }
}
