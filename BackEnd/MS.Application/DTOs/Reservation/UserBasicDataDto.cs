using System;

namespace MS.Application.DTOs.Reservation
{
    public class UserBasicDataDto
    {
        public string NID { get; set; }
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
    }
}
