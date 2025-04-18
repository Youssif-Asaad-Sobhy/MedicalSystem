using Microsoft.Extensions.Logging;
using MS.Application.DTOs.Attachment;
using MS.Application.DTOs.Test;
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
using MS.Application.Helpers.Pagination;

namespace MS.Application.Services
{
    public class TestService : ITestService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAttachmentService _attachmentService;
        public TestService(IUnitOfWork unitOfWork, IAttachmentService attachmentService)
        {
            _unitOfWork = unitOfWork;
            _attachmentService = attachmentService;
        }

        public async Task<Response<Test>> CreateTestAsync(CreateTestDto model)
        {
            if (model is null)
            {
                return ResponseHandler.BadRequest<Test>($"Test model not found.");
            }
            var test = new Test()
            {
                Name = model.Name,
            };
             await _unitOfWork.Tests.AddAsync(test);
            var dto=new UploadFileDTO()
            {
                File=model.Photo,
                FolderName="TestPhoto",
                ParentId=test.ID,
            };
            var res= await _attachmentService.UploadFileAsync(dto);
            int photoId=res.Data.ID;
            test.PhotoID=photoId;
            await _unitOfWork.Tests.UpdateAsync(test);
            return ResponseHandler.Created(test);
        }

        public async Task<Response<Test>> DeleteTestAsync(int ID)
        {
            var test = await _unitOfWork.Tests.GetByIdAsync(ID);
            if (test is null || ID == 0)
            {
                return ResponseHandler.BadRequest<Test>($"Test with ID {ID} not found.");
            }
            await _unitOfWork.Tests.DeleteAsync(test);
            return ResponseHandler.Deleted<Test>();
        }

        public async Task<Response<Test>> GetTestAsync(int ID)
        {
            var test = await _unitOfWork.Tests.GetByIdAsync(ID);
            if (test is null || ID == 0)
            {
                return ResponseHandler.BadRequest<Test>($"Test with ID {ID} not found.");
            }
            return ResponseHandler.Success<Test>(test);
        }

        public async Task<Response<Test>> UpdateTestAsync(UpdateTestDto model)
        {
            if (model is null || model.ID == 0)
            {
                return ResponseHandler.BadRequest<Test>($"Test with ID {model.ID} not found.");
            }
            var test = await _unitOfWork.Tests.GetByIdAsync(model.ID);
            if (test is null || test.ID == 0)
            {
                return ResponseHandler.BadRequest<Test>($"Test with ID {model.ID} not found.");
            }
            test.Name = model.Name;

            
            await _unitOfWork.Tests.UpdateAsync(test);
            return ResponseHandler.Updated(test);
        }
        public async Task<PaginatedResult<List<DetailedTest>>> GetAllTestAsync(string[]? filter, PageFilter? pageFilter, string? search = null)
        {
            var OutputList = new List<DetailedTest>();
            var tests = await _unitOfWork.Tests.GetAllFilteredAsync(filter);

            if (!search.IsNullOrEmpty())
            {
                tests = tests.Where(t => t.Name.Contains(search));
            }

            if (tests is null)
            {
                return ResponseHandler.BadRequest<List<DetailedTest>>(pageFilter, "Test model is null or not found");
            }

            foreach (Test test in tests)
            {
                var detailedTest = new DetailedTest()
                {
                    ID = test.ID,
                    Name = test.Name,
                    Description = test.Description,
                    PhotoID = test.PhotoID,
                    Photo = test.Photo
                };

                OutputList.Add(detailedTest);
            }

            var count = OutputList.Count();
            var detailedTests = OutputList.Skip((pageFilter.PageNumber - 1) * pageFilter.PageSize)
                .Take(pageFilter.PageSize).ToList();
            return ResponseHandler.Success(detailedTests, pageFilter, count);
        }
    }
}
