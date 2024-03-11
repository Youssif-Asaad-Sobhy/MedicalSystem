using MS.Application.DTOs.Clinc;
using MS.Application.Helpers.Response;
using MS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.Interfaces
{
    public interface IClinicService
    {
        Task<Response<Clinic>> GetClinicAsync(int ClinicID);
        Task<Response<Clinic>> DeleteClinicAsync(int ClinicID);
        Task<Response<Clinic>> UpdateClinicAsync(UpdateClinicDto model);
        Task<Response<Clinic>> CreateClinicAsync(CreateClinicDto model);
        Task<Response<IEnumerable<Clinic>>> GetAllClinicsWithDepartmentIdAsync(int departmentId);
    }
}
