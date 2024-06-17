using Microsoft.Extensions.Logging;
using MS.Application.DTOs.Attachment;
using MS.Application.DTOs.TestLab;
using MS.Application.Helpers.Response;
using MS.Application.Interfaces;
using MS.Data.Entities;
using MS.Infrastructure.Repositories.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using MS.Application.DTOs.Hospital;
using MS.Application.DTOs.Lab;
using MS.Application.DTOs.Test;
using MS.Application.Helpers.Pagination;

namespace MS.Application.Services
{
    public class TestLabService : ITestLabService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAttachmentService _attachmentService;

        public TestLabService(IUnitOfWork unitOfWork, IAttachmentService attachmentService)
        {
            _unitOfWork = unitOfWork;
            _attachmentService = attachmentService;
        }

        public async Task<Response<TestLab>> CreateTestLabAsync(CreateTestLabDto model)
        {
            if (model is null)
            {
                return ResponseHandler.BadRequest<TestLab>($"Test model not found.");
            }
            var testlab = new TestLab()
            {
                TestID=model .TestID,
                LabID=model .TestID,
                Price=model .Price,
                Description=model .Description,
            };
            await _unitOfWork.TestLabs.AddAsync(testlab);
            return ResponseHandler.Created(testlab);
        }

        public async Task<Response<TestLab>> DeleteTestLabAsync(int ID)
        {
            var testlab = await _unitOfWork.TestLabs.GetByIdAsync(ID);
            if (testlab is null || ID == 0)
            {
                return ResponseHandler.BadRequest<TestLab>($"Test with ID {ID} not found.");
            }
            await _unitOfWork.TestLabs.DeleteAsync(testlab);
            return ResponseHandler.Deleted<TestLab>();
        }

        public async Task<Response<TestLab>> GetTestLabAsync(int ID)
        {
            var testlab = await _unitOfWork.TestLabs.GetByIdAsync(ID);
            if (testlab is null || ID == 0)
            {
                return ResponseHandler.BadRequest<TestLab>($"TestLab with ID {ID} not found.");
            }
            return ResponseHandler.Success(testlab);
        }

        public async Task<Response<List<AllTestDto>>> GetTestListAsync()
        {
            var tests = await _unitOfWork.TestLabs.GetAllAsync([x=>x.Test, x=>x.Test.Photo]);
            if (tests is null)
            {
                return ResponseHandler.BadRequest<List<AllTestDto>>($"No tests found.");
            }
            var result = new List<AllTestDto>();
            foreach (var test in tests)
            {

                var dto = new DownloadFileDTO()
                {
                    FolderName = "Test",
                    FileName =test.Test?.Photo?.FileName,
                };
                var ph =await _attachmentService.DownloadFileAsync(dto);
                var res = new AllTestDto()
                {
                    ID = test.ID,
                    Name = test.Test?.Name,
                    price = test.Price,
                    photo=test.Test?.Photo?.ViewUrl
                };
                result.Add(res);
            }
            return ResponseHandler.Success(result);
        }

        public async Task<Response<TestLab>> UpdateTestLabAsync(UpdateTestLabDto model)
        {
            if (model is null || model.ID == 0)
            {
                return ResponseHandler.BadRequest<TestLab>($"TestLab with ID {model.ID} not found.");
            }
            var testlab = await _unitOfWork.TestLabs.GetByIdAsync(model.ID);
            if (testlab is null || testlab.ID == 0)
            {
                return ResponseHandler.BadRequest<TestLab>($"TestLab with ID {model.ID} not found.");
            }
            testlab.TestID = model.TestID;
            testlab.LabID = model.TestID;
            testlab.Price = model.Price;
            testlab.Description = model.Description;
            await _unitOfWork.TestLabs.UpdateAsync(testlab);
            return ResponseHandler.Updated(testlab);
        }
        public async Task<PaginatedResult<List<DetailedTestLab>>> GetAllTestLabAsync(string[]? filter, PageFilter? pageFilter, string? search = null)
        {
            var OutputList = new List<DetailedTestLab>();
            var testLabs = await _unitOfWork.TestLabs.GetAllFilteredAsync(filter, [d=>d.Lab,d=>d.Lab.Hospital,d=>d.Test]);

            if (!search.IsNullOrEmpty())
            {
                testLabs = testLabs.Where(t => t.Description.Contains(search));
            }

            if (testLabs is null)
            {
                return ResponseHandler.BadRequest<List<DetailedTestLab>>(pageFilter, "TestLab model is null or not found");
            }

            foreach (TestLab testLab in testLabs)
            {
                var detailedTestLab = new DetailedTestLab()
                {
                    ID = testLab.ID,
                    TestID = testLab.TestID,
                    LabID = testLab.LabID,
                    Price = testLab.Price,
                    Description = testLab.Description,
                    Lab = new DetailedLab
                    {
                        ID = testLab.Lab.ID,
                        Name = testLab.Lab.Name,
                        Type = testLab.Lab.Type,
                        HospitalID = testLab.Lab.HospitalID,
                        Hospital = new DetailedHospital
                        {
                            ID = testLab.Lab.Hospital.ID,
                            Name = testLab.Lab.Hospital.Name,
                            Phone = testLab.Lab.Hospital.Phone,
                            Government = testLab.Lab.Hospital.Government,
                            City = testLab.Lab.Hospital.City,
                            Country = testLab.Lab.Hospital.Country,
                            Type = testLab.Lab.Hospital.Type
                        }
                    },
                    Test = new DetailedTest
                    {
                        ID = testLab.Test.ID,
                        Name = testLab.Test.Name,
                        Description = testLab.Test.Description,
                        PhotoID = testLab.Test.PhotoID,
                        Photo = testLab.Test.Photo
                    }
                };

                OutputList.Add(detailedTestLab);
            }

            var count = OutputList.Count();
            var detailedTestLabs = OutputList.Skip((pageFilter.PageNumber - 1) * pageFilter.PageSize)
                .Take(pageFilter.PageSize).ToList();
            return ResponseHandler.Success(detailedTestLabs, pageFilter, count);
        }    
    }
}
