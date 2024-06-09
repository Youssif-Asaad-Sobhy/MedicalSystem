using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Data.Entities
{
    public class TestResult
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int TestId { get; set; }
        public Test Test { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public ICollection<Attachment> Attachments { get; set; }
    }
}
