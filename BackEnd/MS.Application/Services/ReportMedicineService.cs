using Microsoft.Extensions.Logging;
using MS.Application.DTOs.ReportMedicine;
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
    public class ReportMedicineService : IReportMedicineService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ReportMedicineService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Response<ReportMedicine>> CreateReportMedicineAsync(CreateReportMedicineDto model)
        {
            if (model is null)
            {
                return ResponseHandler.BadRequest<ReportMedicine>($"ReportMedicine model not found.");
            }
            var ReportMedicine = new ReportMedicine()
            {
                ReportID = model.ReportID,
                MedicineTypeID = model.MedicineTypeID,
            };
            await _unitOfWork.ReportMedicines.AddAsync(ReportMedicine);
            return ResponseHandler.Created(ReportMedicine);
        }

        public async Task<Response<ReportMedicine>> DeleteReportMedicineAsync(int ID)
        {
            var ReportMedicine = await _unitOfWork.ReportMedicines.GetByIdAsync(ID);
            if (ReportMedicine is null || ID == 0)
            {
                return ResponseHandler.BadRequest<ReportMedicine>($"ReportMedicine with ID {ID} not found.");
            }
            await _unitOfWork.ReportMedicines.DeleteAsync(ReportMedicine);
            return ResponseHandler.Deleted<ReportMedicine>();
        }

        public async Task<Response<ReportMedicine>> GetReportMedicineAsync(int ID)
        {
            var ReportMedicine = await _unitOfWork.ReportMedicines.GetByIdAsync(ID);
            if (ReportMedicine is null || ID == 0)
            {
                return ResponseHandler.BadRequest<ReportMedicine>($"ReportMedicine with ID {ID} not found.");
            }
            return ResponseHandler.Success<ReportMedicine>(ReportMedicine);
        }

        public async Task<Response<ReportMedicine>> UpdateReportMedicineAsync(UpdateReportMedicineDto model)
        {
            if (model is null || model.ID == 0)
            {
                return ResponseHandler.BadRequest<ReportMedicine>($"ReportMedicine with ID {model.ID} not found.");
            }
            var ReportMedicine = await _unitOfWork.ReportMedicines.GetByIdAsync(model.ID);
            if (ReportMedicine is null || ReportMedicine.ID == 0)
            {
                return ResponseHandler.BadRequest<ReportMedicine>($"ReportMedicine with ID {model.ID} not found.");
            }
            ReportMedicine.ReportID = model.ReportID;
            ReportMedicine.MedicineTypeID = model.MedicineTypeID;

            await _unitOfWork.ReportMedicines.UpdateAsync(ReportMedicine);
            return ResponseHandler.Updated(ReportMedicine);
        }
    }
}
