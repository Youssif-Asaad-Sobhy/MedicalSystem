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
        Task<Response<PlacePrice>> GetClinicPriceAsync(int ID);
        Task<Response<PlacePrice>> DeleteClinicPriceAsync(int ID);
        Task<Response<PlacePrice>> UpdateClinicPriceAsync(UpdateClinicPriceDto model);
        Task<Response<PlacePrice>> CreateClinicPriceAsync(CreateClinicPriceDto model);
    }
}
