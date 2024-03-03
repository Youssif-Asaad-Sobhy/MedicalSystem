using MS.Application.DTOs.Clinc;
using MS.Application.DTOs.ClinicPrice;
using MS.Application.Helpers.Response;
using MS.Data.Entities;
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
    }
}
