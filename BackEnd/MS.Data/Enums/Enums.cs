using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MS.Data.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum WeekDays
    {
        [Description("Saturday")]
        Saturday = 1,
        [Description("Sunday")]
        Sunday = 2,
        [Description("Monday")]
        Monday = 3,
        [Description("Tuesday")]
        Tuesday = 4,
        [Description("Wednesday")]
        Wednesday = 5,
        [Description("Thursday")]
        Thursday = 6,
        [Description("Friday")]
        Friday = 7
    }   
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum FileType
    {
        [Description("PDF File")]
        PDF=1,
        [Description("Word File")]
        DOCX =2,
        [Description("Photo")]
        Photo =3
    }   
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ReservationState
    {
        [Description("Running")]
        Running,
        [Description("Done")]
        Done
    }
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PlaceType
    {
        [Description("Clinic")]
        Clinic,
        [Description("Lab")]
        Lab,
        [Description("Pharmcy")]
        Pharmacy
    }
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum LabType
    {
        [Description("Blood")]
        Lab,
        [Description("X-Ray")]
        XRay
    }
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum HospitalType
    {
        [Description("Public")]
        Public,
        [Description("Private")]
        Private
    }
}
