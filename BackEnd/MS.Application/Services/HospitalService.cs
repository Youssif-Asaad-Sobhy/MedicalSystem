using MS.Application.DTOs.Equipment;
using MS.Application.DTOs.Hospital;
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
    public class HospitalService : IHospitalService
    {
        private readonly IUnitOfWork _unitOfWork;

        public HospitalService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Response<Hospital>> CreateHospitalAsync(CreateHospitalDto model)
        {
            if (model == null)
            {
                return ResponseHandler.BadRequest<Hospital>($"Model not found.");
            }
            var Entity = new Hospital()
            {
                Name = model.Name,
                City = model.City,
                Country = model.Country,
                Government = model.Government,
                Phone = model.Phone,
                Type = model.Type
            };
            await _unitOfWork.Hospitals.AddAsync(Entity);
            return ResponseHandler.Created(Entity);
        }

        public async Task<Response<Hospital>> DeleteHospitalAsync(int ID)
        {
            var Entity = await _unitOfWork.Hospitals.GetByIdAsync(ID);
            if (Entity is null || ID == 0)
            {
                return ResponseHandler.BadRequest<Hospital>("model is null or not found");
            }
            await _unitOfWork.Hospitals.DeleteAsync(Entity);
            return ResponseHandler.Deleted<Hospital>();
        }

        public async Task<Response<Hospital>> GetHospitalAsync(int ID)
        {
            var Entity = await _unitOfWork.Hospitals.GetByIdAsync(ID);
            if (Entity is null || ID == 0)
            {
                return ResponseHandler.BadRequest<Hospital>("model is null or not found");
            }
            return ResponseHandler.Success(Entity);
        }

        public async Task<Response<Hospital>> UpdateHospitalAsync(UpdateHospitalDto model)
        {
            var Entity = await _unitOfWork.Hospitals.GetByIdAsync(model.ID);
            if (Entity is null || model.ID == 0)
            {
                return ResponseHandler.BadRequest<Hospital>("model is null or not found");
            }
            Entity.Name = model.Name;
            Entity.Country = model.Country;
            Entity.Phone = model.Phone;
            Entity.City = model.City;
            Entity.Government = model.Government;
            Entity.Phone = model.Phone;
            await _unitOfWork.Hospitals.UpdateAsync(Entity);
            return ResponseHandler.Success(Entity);
        }
    }
}
