using MS.Application.DTOs.ClinicPrice;
using MS.Application.Helpers.Response;
using MS.Application.Interfaces;
using MS.Data.Entities;
using MS.Data.Enums;
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
        public async Task<Response<PlacePrice>> CreatePlacePriceAsync(CreatePlacePriceDto model)
        {
            if (model is null )
            {
                return ResponseHandler.BadRequest<PlacePrice>($"ClinicPrice model not found.");
            }
            var clinicprice = new PlacePrice()
            {
                Name = model.Name,
                Price = model.Price,
                PlaceType= model.PlaceType,
                PlaceID = model.PlaceID
            };
            await _unitOfWork.PlacePrice.AddAsync(clinicprice);
            return ResponseHandler.Created<PlacePrice>(clinicprice);
        }

        public async Task<Response<PlacePrice>> DeletePlacePriceAsync(int ID)
        {
            var ClinicPrice = await _unitOfWork.PlacePrice.GetByIdAsync(ID);
            if (ClinicPrice == null || ID == 0)
            {
                return ResponseHandler.BadRequest<PlacePrice>($"ClinicPrice with ID {ID} not found.");
            }
            await _unitOfWork.PlacePrice.DeleteAsync(ClinicPrice);
            return ResponseHandler.Deleted<PlacePrice>();
        }

        public async Task<Response<PlacePrice>> GetPlacePriceAsync(int ID)
        {
            var ClinicPrice = await _unitOfWork.PlacePrice.GetByIdAsync(ID);
            if (ClinicPrice == null || ID == 0)
            {
                return ResponseHandler.BadRequest<PlacePrice>($"ClinicPrice with ID {ID} not found.");
            }
            return ResponseHandler.Success(ClinicPrice);
        }

        
        public async Task<Response<IEnumerable<PlacePrice>>> GetAllPlacePricesAsync(PlaceType placeType, int placeId)
        {
            var places = await _unitOfWork.PlacePrice.GetByExpressionAsync(x=>x.PlaceID==placeId && x.PlaceType == placeType);
            if (places == null || !places.Any())
            {
                return ResponseHandler.BadRequest<IEnumerable<PlacePrice>>($"placeId or placeType is wrong or there is not prices for this place");
            }
            return ResponseHandler.Success(places);
        }

        public async Task<Response<PlacePrice>> UpdatePlacePriceAsync(UpdatePlacePriceDto model)
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
