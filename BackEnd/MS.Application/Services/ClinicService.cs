using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using MS.Application.DTOs.Clinc;
using MS.Application.DTOs.Shift;
using MS.Application.Helpers.Pagination;
using MS.Application.Helpers.Response;
using MS.Application.Interfaces;
using MS.Data.Entities;
using MS.Data.Enums;
using MS.Infrastructure.Contexts;
using MS.Infrastructure.Repositories.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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
                DepartmentID=model.DepartmentID,
                Description=model.Description,
                WorkDays=model.WorkDays,
                PhotoID=model.PhotoID
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
            clinic.Description = model.Description;
            clinic.WorkDays = model.WorkDays;
            clinic.PhotoID = model.PhotoID;

            await _unitOfWork.Clinics.UpdateAsync(clinic);
            return ResponseHandler.Updated(clinic);
        }
        public async Task<PaginatedResult<List<DetailedClinic>>> GetAllClinicsAsync(string[]? filter, PageFilter? pageFilter, string? search = null)
        {
            var OutputList = new List<DetailedClinic>();
            var clinics = await _unitOfWork.Clinics.GetAllFilteredAsync(filter);
            if (!search.IsNullOrEmpty())
            {
                clinics = clinics.Where(c => c.Name.Contains(search) || c.Description.Contains(search));
            }


            if (clinics is null)
            {
                return ResponseHandler.BadRequest<List<DetailedClinic>>(pageFilter, "clinic model is null or not found");
            }

            foreach (Clinic clinic in clinics)
            {
                var detailedClinic = await _unitOfWork.Clinics.GetByExpressionSingleAsync(c => c.ID == clinic.ID,
                    [c => c.PlacePrices,
                     c => c.Photo,
                     c => c.PlaceShifts,
                     c => c.Department,
                     c => c.Reservations]);

                if (detailedClinic is null)
                {
                    return ResponseHandler.BadRequest<List<DetailedClinic>>(pageFilter, "clinic model is null or not found");
                }

                var result = await _reservationService.GetUsersByPlace(detailedClinic.ID, PlaceType.Clinic);
                int reservationCount = result.Succeeded ? result.Data.Count() : 0;

                var clinicData = new DetailedClinic()
                {
                    ID = detailedClinic.ID,
                    Name = detailedClinic.Name,
                    DepartmentID = detailedClinic.DepartmentID,
                    DepartmentName = detailedClinic.Department.Name,
                    description = detailedClinic.Description,
                    reservationCount = reservationCount,
                    Price = detailedClinic.PlacePrices.FirstOrDefault().Price,
                    PhotoID = detailedClinic.PhotoID,
                    Photo = detailedClinic.Photo?.ViewUrl,
                    workdays = detailedClinic.WorkDays,
                    Shifts = new List<ShiftBasicData>()
                };

                foreach (var placeShift in detailedClinic.PlaceShifts)
                {
                    var shift = await _unitOfWork.PlaceShifts.GetByExpressionSingleAsync(s => s.ID == placeShift.ShiftID, [ps => ps.Shift]);

                    var shiftData = new ShiftBasicData()
                    {
                        ID = shift.Shift.ID,
                        Name = shift?.Shift.Name,
                        StartTime = shift?.Shift.StartTime,
                        EndTime = shift?.Shift.EndTime,
                    };

                    clinicData.Shifts.Add(shiftData);
                }

                OutputList.Add(clinicData);
            }
            var count = OutputList.Count();
            var detailedClinics = OutputList.Skip((pageFilter.PageNumber - 1) * pageFilter.PageSize)
                                 .Take(pageFilter.PageSize).ToList();
            return ResponseHandler.Success(detailedClinics,pageFilter,count);
            //تم عمل هذه النقاشة بواسطة زياد عبدالنبي
        }
    }
}
