using MS.Application.Helpers.Response;
using MS.Application.Interfaces;
using MS.Data.Entities;
using MS.Infrastructure.Repositories.UnitOfWork;
using MS.Application.DTOs.Test;
using MS.Application.DTOs.Attachment;
using MS.Application.DTOs.TestResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using MS.Application.Helpers.Pagination;

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
        public async Task<Response<List<GetAllTestResultDto>>> GetAllTestResultAsync(string userId)
        {
            var testResults = await _unitOfWork.TestResults.GetByExpressionAsync(x => x.ApplicationUserId == userId, [x=>x.Attachments,x=>x.Test]);
            if (!testResults.Any())
            {
                return ResponseHandler.Success<List<GetAllTestResultDto>>("No Data found");
            }

            var testResultDtos = testResults.Select(tr => new GetAllTestResultDto
            {
                Title = tr.Title,
                Description = tr.Description,
                TestId = tr.TestId,
                
                Test = new TestDto
                {
                    ID = tr.Test.ID,
                    Name = tr.Test.Name,
                    Description = tr.Test.Description,
                    PhotoID = tr.Test.PhotoID,
                },
                Files = tr.Attachments.Select(a => new FileDto
                {
                    ID = a.ID,
                    FileName = a.FileName,
                    FolderName = a.FolderName,
                    Title = a.Title,
                    ViewUrl = a.ViewUrl,
                    DownloadUrl = a.DownloadUrl,
                    Type = a.Type,
                    FilePath = a.Filepath,
                }).ToList()
            }).ToList();
            
            return ResponseHandler.Success(testResultDtos);
        }
        public async Task<PaginatedResult<List<DetailedTestResult>>> GetAllTestResultAsync(string[]? filter, PageFilter? pageFilter, string? search = null)
        {
            var OutputList = new List<DetailedTestResult>();
            var testResults = await _unitOfWork.TestResults.GetAllFilteredAsync(filter, [d=>d.Test,d=>d.Attachments]);

            if (!search.IsNullOrEmpty())
            {
                testResults = testResults.Where(t => t.Title.Contains(search));
            }

            if (testResults is null)
            {
                return ResponseHandler.BadRequest<List<DetailedTestResult>>(pageFilter, "TestResult model is null or not found");
            }

            foreach (TestResult testResult in testResults)
            {
                var detailedTestResult = new DetailedTestResult()
                {
                    Title = testResult.Title,
                    Description = testResult.Description,
                    TestId = testResult.TestId,
                    Test = new DetailedTest
                    {
                        ID = testResult.Test.ID,
                        Name = testResult.Test.Name,
                        Description = testResult.Test.Description,
                        PhotoID = testResult.Test.PhotoID
                    },
                    Files = testResult.Attachments.Select(file => new FileDto
                    {
                        ID = file.ID,
                        FileName = file.FileName,
                        FolderName = file.FolderName,
                        Title = file.Title,
                        ViewUrl = file.ViewUrl,
                        DownloadUrl = file.DownloadUrl,
                        Type = file.Type,
                        FilePath = file.Filepath
                        
                    }).ToList(),
                    ApplicationUserId = testResult.ApplicationUserId
                };

                OutputList.Add(detailedTestResult);
            }

            var count = OutputList.Count();
            var detailedTestResults = OutputList.Skip((pageFilter.PageNumber - 1) * pageFilter.PageSize)
                .Take(pageFilter.PageSize).ToList();
            return ResponseHandler.Success(detailedTestResults, pageFilter, count);
        }
    }
}