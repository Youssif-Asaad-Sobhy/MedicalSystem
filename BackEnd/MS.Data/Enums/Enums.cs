﻿using System;
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
    public enum FileType
    {
        PDF=1,
        DOCX=2,
        Photo=3
    }   
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ReservationState
    {
        Running,
        Done
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
