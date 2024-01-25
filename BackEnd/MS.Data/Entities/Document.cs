using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Data.Entities
{
    public class Document
    {
        public int ID { get; set; }
        public byte[] Content { get; set; }
        public int ReportID { get; set; }
        public Report Report { get; set; }
    }
}
