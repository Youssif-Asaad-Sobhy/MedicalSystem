using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Data.Entities
{
    public class Test
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int PhotoID { get; set; }
        public Attachment Photo { get; set; }
        public ICollection<TestLab> TestLabs { get; set; }
    }
}
