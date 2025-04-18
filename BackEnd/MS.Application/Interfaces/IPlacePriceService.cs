using MS.Application.DTOs.Clinc;
using MS.Application.DTOs.ClinicPrice;
using MS.Application.DTOs.PlacePrice;
using MS.Application.Helpers.Pagination;
using MS.Application.Helpers.Response;
using MS.Data.Entities;
using MS.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.Interfaces
{
    public interface IPlacePriceService
    {
        Task<Response<PlacePrice>> GetPlacePriceAsync(int ID);
        Task<Response<PlacePrice>> DeletePlacePriceAsync(int ID);
        Task<Response<PlacePrice>> UpdatePlacePriceAsync(UpdatePlacePriceDto model);
        Task<Response<PlacePrice>> CreatePlacePriceAsync(CreatePlacePriceDto model);
        Task<Response<IEnumerable<PlacePrice>>> GetAllPlacePricesAsync(PlaceType placeType,int placeId);
        Task<PaginatedResult<List<DetailedPlacePrice>>> GetAllPlacePriceAsync(string[]? filter, PageFilter? pageFilter, string? search = null);

    }
}
