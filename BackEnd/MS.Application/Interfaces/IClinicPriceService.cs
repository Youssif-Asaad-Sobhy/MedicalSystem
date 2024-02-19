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
    public interface IClinicPriceService
    {
        Task<Response<ClinicPrice>> GetClinicPriceAsync(int ID);
        Task<Response<ClinicPrice>> DeleteClinicPriceAsync(int ID);
        Task<Response<ClinicPrice>> UpdateClinicPriceAsync(UpdateClinicPriceDto model);
        Task<Response<ClinicPrice>> CreateClinicPriceAsync(CreateClinicPriceDto model);
    }
}
