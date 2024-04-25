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

namespace MS.Application.Services
{
    public class TestLabService : ITestLabService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AttachmentService _attachmentService;

        public TestLabService(IUnitOfWork unitOfWork, AttachmentService attachmentService)
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
                TestLabID=model .TestLabID,
                LabID=model .TestLabID,
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
                    FolderName = "TestPhoto",
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
            testlab.TestLabID = model.TestLabID;
            testlab.LabID = model.TestLabID;
            testlab.Price = model.Price;
            testlab.Description = model.Description;
            await _unitOfWork.TestLabs.UpdateAsync(testlab);
            return ResponseHandler.Updated(testlab);
        }
    }
}
