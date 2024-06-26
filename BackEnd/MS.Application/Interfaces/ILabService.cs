﻿using MS.Application.DTOs.Lab;
using MS.Application.Helpers.Response;
using MS.Data.Entities;
using System.Threading.Tasks;

namespace MS.Application.Interfaces
{
    public interface ILabService
    {
        Task<Response<Lab>> GetLabAsync(int ID);
        Task<Response<Lab>> DeleteLabAsync(int ID);
        Task<Response<Lab>> UpdateLabAsync(UpdateLabDto model);
        Task<Response<Lab>> CreateLabAsync(CreateLabDto model);
        Task<Response<IEnumerable<Lab>>> GetLabsAsync();
    }
}
