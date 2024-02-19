using MS.Application.DTOs.ClinicPrice;
using MS.Application.Helpers.Response;
using MS.Application.Interfaces;
using MS.Data.Entities;
using MS.Infrastructure.Repositories.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.Services
{
    public class ClinicPriceService : IClinicPriceService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ClinicPriceService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Response<ClinicPrice>> CreateClinicPriceAsync(UpdateClinicPriceDto model)
        {
            if (model is null || model.ID==0)
            {
                return ResponseHandler.BadRequest<ClinicPrice>($"ClinicPrice with ID {model.ID} not found.");
            }
            var clinicprice = new ClinicPrice()
            {
                Name=model.Name,
                Price=model.Price,
                ClinicID=model.ClinicID
            };
            await _unitOfWork.ClinicPrices.AddAsync(clinicprice);
            return ResponseHandler.Created<ClinicPrice>(clinicprice);
        }

        public async Task<Response<ClinicPrice>> DeleteClinicPriceAsync(int ID)
        {
            var ClinicPrice = await _unitOfWork.ClinicPrices.GetByIdAsync(ID);
            if (ClinicPrice == null || ID == 0)
            {
                return ResponseHandler.BadRequest<ClinicPrice>($"ClinicPrice with ID {ID} not found.");
            }
            await _unitOfWork.ClinicPrices.DeleteAsync(ClinicPrice);
            return ResponseHandler.Deleted<ClinicPrice>();
        }

        public async Task<Response<ClinicPrice>> GetClinicPriceAsync(int ID)
        {
            var ClinicPrice = await _unitOfWork.ClinicPrices.GetByIdAsync(ID);
            if (ClinicPrice == null || ID == 0)
            {
                return ResponseHandler.BadRequest<ClinicPrice>($"ClinicPrice with ID {ID} not found.");
            }
            return ResponseHandler.Success(ClinicPrice);
        }

        public async Task<Response<ClinicPrice>> UpdateClinicPriceAsync(UpdateClinicPriceDto model)
        {
            if (model == null|| model.ID==0)
            {
                return ResponseHandler.BadRequest<ClinicPrice>($"Clinic with ID {model.ID} not found.");
            }
            var clinicprice = await _unitOfWork.ClinicPrices.GetByIdAsync(model.ID);
            if (clinicprice == null || clinicprice.ID == 0)
            {
                return ResponseHandler.BadRequest<ClinicPrice>($"Clinic with ID {model.ID} not found.");
            }
            clinicprice.Name = model.Name;
            clinicprice.Price = model.Price;
            clinicprice.ClinicID = model.ClinicID;
            await _unitOfWork.ClinicPrices.UpdateAsync(clinicprice);
            return ResponseHandler.Updated(clinicprice);
        }
    }
}
