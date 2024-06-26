﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Data.Entities
{
    public class ApplicationUserDisease
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public double ValueResult { get; set; }
        public string Description { get; set; }
        public double? Height { get; set; }
        public double? Weight { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public int DiseaseId { get; set; }
        public Disease Disease { get; set; }
        public string Diagnosis { get; set; }
        public DateTime DiagnosisDate { get; set; }
        public ICollection<Attachment> Attachments { get; set; }
    }
}
