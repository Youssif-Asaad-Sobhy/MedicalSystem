﻿using MS.Application.DTOs.Clinc;
using MS.Application.DTOs.Shift;
using MS.Application.Helpers.Pagination;
using MS.Application.Helpers.Response;
using MS.Data.Entities;
using System.Threading.Tasks;

namespace MS.Application.Interfaces
{
    public interface IShiftService
    {
        Task<Response<Shift>> GetShiftAsync(int ID);
        Task<Response<Shift>> DeleteShiftAsync(int ID);
        Task<Response<Shift>> UpdateShiftAsync(UpdateShiftDto model);
        Task<Response<Shift>> CreateShiftAsync(CreateShiftDto model);
        Task<PaginatedResult<List<DetailedShift>>> GetAllshiftAsync(string[]? filter, PageFilter? pageFilter, string? search = null);

    }
}
