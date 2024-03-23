using Microsoft.Extensions.Logging;
using MS.Application.DTOs.Report;
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
    public class ReportService : IReportService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ReportService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Response<Report>> CreateReportAsync(CreateReportDto model)
        {
            if (model is null)
            {
                return ResponseHandler.BadRequest<Report>($"Report model not found.");
            }
            var Report = new Report()
            {
                Time = model.Time,
                Description = model.Description,
                UserID = model.UserID,
                DoctorID = model.DoctorID,
            };
            await _unitOfWork.Reports.AddAsync(Report);
            return ResponseHandler.Created(Report);
        }

        public async Task<Response<Report>> DeleteReportAsync(int ID)
        {
            var Report = await _unitOfWork.Reports.GetByIdAsync(ID);
            if (Report is null || ID == 0)
            {
                return ResponseHandler.BadRequest<Report>($"Report with ID {ID} not found.");
            }
            await _unitOfWork.Reports.DeleteAsync(Report);
            return ResponseHandler.Deleted<Report>();
        }

        public async Task<Response<Report>> GetReportAsync(int ID)
        {
            var Report = await _unitOfWork.Reports.GetByIdAsync(ID);
            if (Report is null || ID == 0)
            {
                return ResponseHandler.BadRequest<Report>($"Report with ID {ID} not found.");
            }
            return ResponseHandler.Success<Report>(Report);
        }

        public async Task<Response<Report>> UpdateReportAsync(UpdateReportDto model)
        {
            if (model is null || model.ID == 0)
            {
                return ResponseHandler.BadRequest<Report>($"Report with ID {model.ID} not found.");
            }
            var Report = await _unitOfWork.Reports.GetByIdAsync(model.ID);
            if (Report is null || Report.ID == 0)
            {
                return ResponseHandler.BadRequest<Report>($"Report with ID {model.ID} not found.");
            }
            Report.Time = model.Time;
            Report.Description = model.Description;
            Report.UserID = model.UserID;
            Report.DoctorID = model.DoctorID;

            await _unitOfWork.Reports.UpdateAsync(Report);
            return ResponseHandler.Updated(Report);
        }
    }
}
