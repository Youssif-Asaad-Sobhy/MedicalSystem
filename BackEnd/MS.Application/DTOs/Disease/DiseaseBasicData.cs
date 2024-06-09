using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.DTOs.Disease
{
    public class DiseaseBasicData
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Symptoms { get; set; }
        public string Causes { get; set; }
    }
}
