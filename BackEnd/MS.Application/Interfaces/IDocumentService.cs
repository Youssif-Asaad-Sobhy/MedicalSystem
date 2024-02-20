using MS.Application.DTOs.Department;
using MS.Application.DTOs.Document;
using MS.Application.Helpers.Response;
using MS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.Interfaces
{
    public interface IDocumentService
    {
        Task<Response<Document>> GetDocByIDAsync(int ID);
        Task<Response<Document>> DeleteDocAsync(int ID);
        Task<Response<Document>> UpdateDocAsync(UpdateEquipmentDto model);
        Task<Response<Document>> CreateDocAsync(CreateEquipmentDto model);
    }
}
