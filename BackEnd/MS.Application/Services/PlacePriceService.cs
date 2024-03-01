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
    public class PlacePriceService : IPlacePriceService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PlacePriceService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Response<PlacePrice>> CreateClinicPriceAsync(CreateClinicPriceDto model)
        {
            if (model is null )
            {
                return ResponseHandler.BadRequest<PlacePrice>($"ClinicPrice model not found.");
            }
            var clinicprice = new PlacePrice()
            {
                Name = model.Name,
                Price = model.Price,
                PlaceID = model.PlaceID
            };
            await _unitOfWork.PlacePrice.AddAsync(clinicprice);
            return ResponseHandler.Created<PlacePrice>(clinicprice);
        }

        public async Task<Response<PlacePrice>> DeleteClinicPriceAsync(int ID)
        {
            var ClinicPrice = await _unitOfWork.PlacePrice.GetByIdAsync(ID);
            if (ClinicPrice == null || ID == 0)
            {
                return ResponseHandler.BadRequest<PlacePrice>($"ClinicPrice with ID {ID} not found.");
            }
            await _unitOfWork.PlacePrice.DeleteAsync(ClinicPrice);
            return ResponseHandler.Deleted<PlacePrice>();
        }

        public async Task<Response<PlacePrice>> GetClinicPriceAsync(int ID)
        {
            var ClinicPrice = await _unitOfWork.PlacePrice.GetByIdAsync(ID);
            if (ClinicPrice == null || ID == 0)
            {
                return ResponseHandler.BadRequest<PlacePrice>($"ClinicPrice with ID {ID} not found.");
            }
            return ResponseHandler.Success(ClinicPrice);
        }

        public async Task<Response<PlacePrice>> UpdateClinicPriceAsync(UpdateClinicPriceDto model)
        {
            if (model == null|| model.ID==0)
            {
                return ResponseHandler.BadRequest<PlacePrice>($"ClinicPrice with ID {model.ID} not found.");
            }
            var clinicprice = await _unitOfWork.PlacePrice.GetByIdAsync(model.ID);
            if (clinicprice == null || clinicprice.ID == 0)
            {
                return ResponseHandler.BadRequest<PlacePrice>($"ClinicPrice with ID {model.ID} not found.");
            }
            clinicprice.Name = model.Name;
            clinicprice.Price = model.Price;
            clinicprice.PlaceID = model.PlaceID;
            await _unitOfWork.PlacePrice.UpdateAsync(clinicprice);
            return ResponseHandler.Updated(clinicprice);
        }
    }
}
