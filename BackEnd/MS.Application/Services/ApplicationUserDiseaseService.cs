using MS.Application.DTOs.ApplicationUserDisease;
using MS.Application.DTOs.Attachment;
using MS.Application.Helpers.Response;
using MS.Application.Interfaces;
using MS.Data.Entities;
using MS.Infrastructure.Repositories.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MS.Application.Services
{
    public class ApplicationUserDiseaseService : IApplicationUserDiseaseService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAttachmentService _attachmentService;

        public ApplicationUserDiseaseService(IUnitOfWork unitOfWork, IAttachmentService attachmentService)
        {
            _unitOfWork = unitOfWork;
            _attachmentService = attachmentService;
        }
        public async Task<Response<ApplicationUserDisease>> CreateApplicationUserDiseaseAsync(CreateApplicationUserDiseaseDto model)
        {
            if (model == null)
            {
                return ResponseHandler.BadRequest<ApplicationUserDisease>($"Model not found.");
            }
            var Entity = new ApplicationUserDisease()
            {
                Type = model.Type,
                ValueResult = model.ValueResult,
                Description = model.Description,
                Height = model.Height,
                Weight = model.Weight,
                ApplicationUserId = model.UserId,
                DiseaseId = model.DiseaseId,
                Diagnosis = model.Diagnosis,
                DiagnosisDate = model.DiagnosisDate,
                Attachments = []
            };
            await _unitOfWork.ApplicationUserDiseases.AddAsync(Entity);
            var dto = new UploadFileDTO()
            {
                File = model.Photo,
                FolderName = "UserDisease",
                ParentId = Entity.ID,
            };
            var res = await _attachmentService.UploadFileAsync(dto);
            int photoId = res.Data.ID;
            Entity.Attachments.Add(new Attachment()
            {
                ID = res.Data.ID,
                ViewUrl = res.Data.ViewUrl,
                DownloadUrl = res.Data.DownloadUrl,
            });
            await _unitOfWork.ApplicationUserDiseases.UpdateAsync(Entity);
            return ResponseHandler.Created(Entity);
        }
        
        public async Task<Response<ApplicationUserDisease>> DeleteApplicationUserDiseaseAsync(int ID)
        {
            var Entity = await _unitOfWork.ApplicationUserDiseases.GetByIdAsync(ID);
            if (Entity is null || ID == 0)
            {
                return ResponseHandler.BadRequest<ApplicationUserDisease>("ApplicationUserDisease not found");
            }
            await _unitOfWork.ApplicationUserDiseases.DeleteAsync(Entity);
            return ResponseHandler.Deleted<ApplicationUserDisease>();
        }

        public async Task<Response<ApplicationUserDisease>> UpdateApplicationUserDiseaseAsync(UpdateApplicationUserDiseaseDto model)
        {
            var Entity = await _unitOfWork.ApplicationUserDiseases.GetByIdAsync(model.ID);
            if (Entity is null || model.ID == 0)
            {
                return ResponseHandler.BadRequest<ApplicationUserDisease>("ApplicationUserDisease not found");
            }
            Entity.Type = model.Type;
            Entity.ValueResult = model.ValueResult;
            Entity.Description = model.Description;
            Entity.Height = model.Height;
            Entity.Weight = model.Weight;
            Entity.ApplicationUserId = model.ApplicationUserId;
            Entity.DiseaseId = model.DiseaseId;
            Entity.Diagnosis = model.Diagnosis;
            Entity.DiagnosisDate = model.DiagnosisDate;
            await _unitOfWork.ApplicationUserDiseases.UpdateAsync(Entity);
            return ResponseHandler.Success(Entity);
        }
        
        public async Task<Response<ApplicationUserDisease>> GetApplicationUserDiseaseAsync(int ID)
        {
            var Entity = await _unitOfWork.ApplicationUserDiseases.GetByIdAsync(ID);
            if (Entity is null || ID == 0)
            {
                return ResponseHandler.BadRequest<ApplicationUserDisease>("ApplicationUserDisease not found");
            }
            return ResponseHandler.Success(Entity);
        }
        
    } 
}
