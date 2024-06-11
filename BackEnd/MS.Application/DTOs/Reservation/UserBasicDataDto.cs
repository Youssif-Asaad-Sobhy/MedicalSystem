using System;
using MS.Application.DTOs.Report;
using MS.Data.Entities;
namespace MS.Application.DTOs.Reservation
{
    public class UserBasicDataDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string NID { get; set; }
        public string BloodType { get; set; }
        public int Age
        {
            get
            {
                if(NID==null)
                {
                    throw new ArgumentNullException(nameof(NID));
                }
                if (NID.Length >= 6 && int.TryParse(NID.Substring(1, 6), out int birthdate))
                {
                    int currentYear = DateTime.Now.Year % 100;
                    int birthYear = birthdate / 10000;
                    int calculatedAge = currentYear - birthYear;
                    if (birthdate % 10000 > DateTime.Now.Month * 100 + DateTime.Now.Day)
                    {
                        calculatedAge--;
                    }
                    return calculatedAge;
                }
                return 0;
            }
        }
        public ICollection<ReportDto> report { get; set;}
    }
}
