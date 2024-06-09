using MS.Application.DTOs.TestResult;
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
    public class TestResultService:ITestResultService
    {
                private readonly IUnitOfWork _unitOfWork;

        public TestResultService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Response<TestResult>> CreateTestResultAsync(CreateTestResultDto model)
        {
            if (model == null)
            {
                return ResponseHandler.BadRequest<TestResult>($"Model not found.");
            }
            var Entity = new TestResult()
            {
                Title = model.Title,
                Description = model.Description,
                TestId = model.TestId,
                ApplicationUserId = model.ApplicationUserId
            };
            await _unitOfWork.TestResults.AddAsync(Entity);
            return ResponseHandler.Created(Entity);
        }

        public async Task<Response<TestResult>> DeleteTestResultAsync(int ID)
        {
            var Entity = await _unitOfWork.TestResults.GetByIdAsync(ID);
            if (Entity is null || ID == 0)
            {
                return ResponseHandler.BadRequest<TestResult>("TestResult not found");
            }
            await _unitOfWork.TestResults.DeleteAsync(Entity);
            return ResponseHandler.Deleted<TestResult>();
        }

        public async Task<Response<TestResult>> UpdateTestResultAsync(UpdateTestResultDto model)
        {
            var Entity = await _unitOfWork.TestResults.GetByIdAsync(model.ID);
            if (Entity is null || model.ID == 0)
            {
                return ResponseHandler.BadRequest<TestResult>("TestResult not found");
            }
            Entity.Title = model.Title;
            Entity.Description = model.Description;
            Entity.TestId = model.TestId;
            Entity.ApplicationUserId = model.ApplicationUserId;
            await _unitOfWork.TestResults.UpdateAsync(Entity);
            return ResponseHandler.Success(Entity);
        }

        public async Task<Response<TestResult>> GetTestResultAsync(int ID)
        {
            var Entity = await _unitOfWork.TestResults.GetByIdAsync(ID);
            if (Entity is null || ID == 0)
            {
                return ResponseHandler.BadRequest<TestResult>("TestResult not found");
            }
            return ResponseHandler.Success(Entity);
        }
    }
}