using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.DTOs.ApplicationUser
{
    public class UserDiseasesDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? MaritalStatus { get; set; }
        public string? Gender { get; set; }
        public string Type { get; set; }
        public double ValueResult { get; set; }
        public string Description { get; set; }
        public double? Height { get; set; }
        public double? Weight { get; set; }
        public string? DiseaseName { get; set; }
        public string? DiseaseDescription { get; set; }
        public string? DiseaseSymptoms { get; set; }
        public string? DiseaseCauses { get; set; }
        public string Diagnosis { get; set; }
        public DateTime DiagnosisDate { get; set; }
        public List<string>? DocViewUrl { get; set;}
    }
}
