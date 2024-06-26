﻿using MS.Application.DTOs.PlaceEquipment;
using MS.Application.Helpers.Response;
using MS.Data.Entities;
using System.Threading.Tasks;

namespace MS.Application.Interfaces
{
    public interface IPlaceEquipmentService
    {
        Task<Response<PlaceEquipment>> GetPlaceEquipmentAsync(int ID);
        Task<Response<PlaceEquipment>> DeletePlaceEquipmentAsync(int ID);
        Task<Response<PlaceEquipment>> UpdatePlaceEquipmentAsync(UpdatePlaceEquipmentDto model);
        Task<Response<PlaceEquipment>> CreatePlaceEquipmentAsync(CreatePlaceEquipmentDto model);
    }
}
