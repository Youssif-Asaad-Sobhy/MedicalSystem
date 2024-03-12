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
    public enum ReservationState
    {
        Done,
        Running
    }
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PlaceType
    {
        Clinic,
        Lab,
        Pharmacy
    }
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum LabType
    {
        Lab,
        XRay
    }
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum HospitalType
    {
        Public,
        Private
    }
}
