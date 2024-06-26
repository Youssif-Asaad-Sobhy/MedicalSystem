﻿using MS.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Data.Entities
{
    public class Attachment
    {
        public int ID { get; set; }
        public string FileName { get; set; }
        public string FolderName { get; set; }
        public string Title { get; set; }
        public string ViewUrl { get; set; }
        public string DownloadUrl { get; set; }
        public string Filepath { get; set; }
        public string Type { get; set; }
        public int? TestId { get; set; }
        public Test? Test { get; set; }
        public int? ClinicId { get; set; }
        public Clinic? Clinic { get; set; }
        public int? UserDiseaseId { get; set; }
        public ApplicationUserDisease? UserDisease { get; set; }
        public int? TestResultID { get; set; }
        public TestResult? TestResult { get; set; }

    }
}
