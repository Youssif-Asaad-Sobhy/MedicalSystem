using System;

namespace MS.Application.DTOs.Reservation
{
    public class UserBasicDataDto
    {
        public string NID { get; set; }
        public string Name { get; set; }
        public int Age
        {
            get
            {
                // Assuming the birthdate is in the format 'YYMMDD'
                if (NID.Length >= 6 && int.TryParse(NID.Substring(0, 6), out int birthdate))
                {
                    // Assuming birthdate is in the format 'YYMMDD'
                    int currentYear = DateTime.Now.Year % 100; // Get the last two digits of the current year
                    int birthYear = birthdate / 10000;
                    int calculatedAge = currentYear - birthYear;

                    // Adjust age based on the birthdate within the current year
                    if (birthdate % 10000 > DateTime.Now.Month * 100 + DateTime.Now.Day)
                    {
                        calculatedAge--;
                    }

                    return calculatedAge;
                }

                // If the format is not as expected or parsing fails, return a default value or handle accordingly
                return 0;
            }
        }
    }
}
