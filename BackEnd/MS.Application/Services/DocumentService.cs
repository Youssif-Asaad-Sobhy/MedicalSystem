using MS.Application.DTOs.Document;
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
    public class DocumentService: IDocumentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DocumentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Response<Document>> CreateDocAsync(CreateDoctDto model)
        {
            if (model == null)
            {
                return ResponseHandler.BadRequest<Document>($"Document model not found.");
            }
            var doc = new Document()
            {
                Content=model.Content,
                ReportID=model.ReportID
            };
            await _unitOfWork.Documents.AddAsync(doc);
            return ResponseHandler.Created(doc);

        }

        public async Task<Response<Document>> DeleteDocAsync(int ID)
        {
            var doc = await _unitOfWork.Documents.GetByIdAsync(ID);
            if (doc is null || ID == 0)
            {
                return ResponseHandler.BadRequest<Document>("document model is null or not found");
            }
            await _unitOfWork.Documents.DeleteAsync(doc);
            return ResponseHandler.Deleted<Document>();
        }

        public async Task<Response<Document>> GetDocByIDAsync(int ID)
        {
            var doc = await _unitOfWork.Documents.GetByIdAsync(ID);
            if (doc is null || ID == 0)
            {
                return ResponseHandler.BadRequest<Document>("document model is null or not found");
            }
            return ResponseHandler.Success<Document>(doc);
        }

        public async Task<Response<Document>> UpdateDocAsync(UpdateDoctDto model)
        {
            var doc = await _unitOfWork.Documents.GetByIdAsync(model.ID);
            if (doc is null || model.ID == 0)
            {
                return ResponseHandler.BadRequest<Document>("document model is null or not found");
            }
            doc.Content = model.Content;
            doc.ReportID = model.ReportID;
            await _unitOfWork.Documents.UpdateAsync(doc);
            return ResponseHandler.Success(doc);
        }
    }
}
