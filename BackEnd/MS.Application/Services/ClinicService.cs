using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using MS.Application.DTOs.Clinc;
using MS.Application.DTOs.Shift;
using MS.Application.Helpers.Filters;
using MS.Application.Helpers.Response;
using MS.Application.Interfaces;
using MS.Data.Entities;
using MS.Data.Enums;
using MS.Infrastructure.Contexts;
using MS.Infrastructure.Repositories.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.Services
{
    public class ClinicService : IClinicService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly Context _context;
        private readonly IReservationService _reservationService;

        public ClinicService(IUnitOfWork unitOfWork, IReservationService reservationService,Context context )
        {
            _unitOfWork = unitOfWork;
            _reservationService = reservationService;
            _context = context;
        }

        public async Task<Response<Clinic>> CreateClinicAsync(CreateClinicDto model)
        {
            if (model is null)
            {
                return ResponseHandler.BadRequest<Clinic>($"clinic model not found.");
            }
            var clinic = new Clinic()
            {
                Name=model.Name,
                DepartmentID=model.DepartmentID
            };
            await _unitOfWork.Clinics.AddAsync(clinic);
            return ResponseHandler.Created(clinic);
        }

        public async Task<Response<Clinic>> DeleteClinicAsync(int ClinicID)
        {
            var clincic = await _unitOfWork.Clinics.GetByIdAsync(ClinicID);
            if (clincic is null)
            {
                return ResponseHandler.BadRequest<Clinic>($"Clinic with ID {ClinicID} not found.");
            }
            await _unitOfWork.Clinics.DeleteAsync(clincic);
            return  ResponseHandler.Deleted<Clinic>();
        }
     
       
        public async Task<Response<DetailedClinic>> GetClinicAsync(int ClinicID)
        {
            var clinic= await _unitOfWork.Clinics.GetByExpressionSingleAsync(c=>c.ID==ClinicID,
                [c => c.PlacePrices, c=>c.Photo, c=>c.PlaceShifts, c=>c.PlaceShifts, c=>c.Department,
                c=>c.Reservations]);
           
            if (clinic is null)
            {
                return ResponseHandler.BadRequest<DetailedClinic>($"Clinic with ID {ClinicID} not found.");
            }
            var result = await _reservationService.GetUsersByPlace(ClinicID, PlaceType.Clinic);
            int x = 0;
            if (result.Succeeded)
            {
                x = result.Data.Count();
            }
            var clinicData = new DetailedClinic()
            {
                ID = clinic.ID,
                Name = clinic.Name,
                DepartmentID = clinic.DepartmentID,
                DepartmentName = clinic.Department.Name,
                description = clinic.Description,
                reservationCount = x,
                Price = clinic.PlacePrices.FirstOrDefault().Price,
                PhotoID = clinic.PhotoID,
                Photo = clinic.Photo.ViewUrl,
                workdays= clinic.WorkDays,
                Shifts = []
            };
            foreach (var item in clinic.PlaceShifts)
            {
                var Placeshift = await _unitOfWork.PlaceShifts.GetByExpressionSingleAsync(s => s.ID == item.ShiftID, [ps=>ps.Shift]);
                var shiftData = new ShiftBasicData()
                {
                    ID= Placeshift.Shift.ID,
                    Name = Placeshift.Shift.Name,
                    StartTime = Placeshift.Shift.StartTime,
                    EndTime = Placeshift.Shift.EndTime,
                };
                clinicData.Shifts.Add(shiftData);
            }
            
            return ResponseHandler.Success(clinicData);
        }

        public async Task<Response<Clinic>> UpdateClinicAsync(UpdateClinicDto model)
        {
            if (model is null ||model.ID==0)
            {
                return ResponseHandler.BadRequest<Clinic>($"Clinic with ID {model.ID} not found.");
            }
            var clinic = await _unitOfWork.Clinics.GetByIdAsync(model.ID);
            if (clinic is null ||clinic.ID==0)
            {
                return ResponseHandler.BadRequest<Clinic>($"Clinic with ID {model.ID} not found.");
            }
            clinic.Name = model.Name;
            clinic.DepartmentID = model.DepartmentID;
            await _unitOfWork.Clinics.UpdateAsync(clinic);
            return ResponseHandler.Updated(clinic);
        }
        public async Task<Response<IEnumerable<Clinic>>> GetAllClinicsWithDepartmentIdAsync(int departmentId)
        {
            var clinics = await _unitOfWork.Clinics.GetByExpressionAsync(c => c.DepartmentID == departmentId);
            return ResponseHandler.Success(clinics);
        }

        public async Task<Response<List<DetailedClinic>>> GetAllClinicsAsync(string[]? filter)
        {
            var OutputList=new List<DetailedClinic>();
            var clinics = await _unitOfWork.Clinics.GetAllFilteredAsync(filter);
            if(clinics is null)
            {
               return ResponseHandler.BadRequest<List<DetailedClinic>>("clinic model is null or not found");
            }
            foreach(Clinic clinic in clinics)
            {
                var Oclinic = await _unitOfWork.Clinics.GetByExpressionSingleAsync(c => c.ID == clinic.ID,
                     [c => c.PlacePrices,
                         c => c.Photo,
                         c => c.PlaceShifts,
                         c => c.Department,
                         c => c.Reservations]);
                if (Oclinic is null)
                {
                    return ResponseHandler.BadRequest<List<DetailedClinic>>("clinic model is null or not found");
                }
                var result = await _reservationService.GetUsersByPlace(Oclinic.ID, PlaceType.Clinic);
                int x = 0;
                if (result.Succeeded)
                {
                    x = result.Data.Count();
                }
                var clinicData = new DetailedClinic()
                {
                    ID = Oclinic.ID,
                    Name = Oclinic.Name,
                    DepartmentID = Oclinic.DepartmentID,
                    DepartmentName = Oclinic.Department.Name,
                    description = Oclinic.Description,
                    reservationCount = x,
                    Price = Oclinic.PlacePrices.FirstOrDefault().Price,
                    PhotoID = Oclinic.PhotoID,
                    Photo = Oclinic.Photo.ViewUrl,
                    workdays = Oclinic.WorkDays,
                    Shifts = []
                };
                foreach (var item in Oclinic.PlaceShifts)
                {
                    var Placeshift = await _unitOfWork.PlaceShifts.GetByExpressionSingleAsync(s => s.ID == item.ShiftID, [ps => ps.Shift]);
                    var shiftData = new ShiftBasicData()
                    {
                        ID = Placeshift.Shift.ID,
                        Name = Placeshift.Shift.Name,
                        StartTime = Placeshift.Shift.StartTime,
                        EndTime = Placeshift.Shift.EndTime,
                    };
                    clinicData.Shifts.Add(shiftData);
                }
                OutputList.Add(clinicData);
            }
            return ResponseHandler.Success(OutputList);
            //تم عمل هذه النقاشة بواسطة زياد عبدالنبي
        }
    }
}
