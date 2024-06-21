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
using Microsoft.IdentityModel.Tokens;
using MS.Application.DTOs.PlacePrice;
using MS.Application.Helpers.Pagination;

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
        public async Task<PaginatedResult<List<DetailedPlacePrice>>> GetAllPlacePriceAsync(string[]? filter, PageFilter? pageFilter, string? search = null)
        {
            var OutputList = new List<DetailedPlacePrice>();
            var placePrices = await _unitOfWork.PlacePrice.GetAllFilteredAsync(filter);

            if (!search.IsNullOrEmpty())
            {
                placePrices = placePrices.Where(p => p.Name.Contains(search));
            }

            if (placePrices is null)
            {
                return ResponseHandler.BadRequest<List<DetailedPlacePrice>>(pageFilter, "PlacePrice model is null or not found");
            }

            foreach (PlacePrice placePrice in placePrices)
            {
                var detailedPlacePrice = new DetailedPlacePrice()
                {
                    ID = placePrice.ID,
                    Name = placePrice.Name,
                    Price = placePrice.Price,
                    PlaceID = placePrice.PlaceID,
                    PlaceType = placePrice.PlaceType
                };

                OutputList.Add(detailedPlacePrice);
            }

            var count = OutputList.Count();
            var detailedPlacePrices = OutputList.Skip((pageFilter.PageNumber - 1) * pageFilter.PageSize)
                .Take(pageFilter.PageSize).ToList();
            return ResponseHandler.Success(detailedPlacePrices, pageFilter, count);
        }
    }
}
