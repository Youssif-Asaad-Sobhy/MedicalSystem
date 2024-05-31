using MS.Application.DTOs.Clinc;
using MS.Application.DTOs.Department;
using MS.Application.Helpers.Filters;
using MS.Application.Helpers.Response;
using MS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.Interfaces
{
    public interface IDepartmentService
    {
        Task<Response<Department>> GetDepartmentByIDAsync(int ID);
        Task<Response<IEnumerable<Department>>> GetAllDepartmentsAsync(string[]? filter);
        Task<Response<Department>> DeleteDepartmentAsync(int DeptID);
        Task<Response<Department>> UpdateDepartmentAsync(UpdateDeptDto model);
        Task<Response<Department>> CreateDepartmentAsync(CreateDeptDto model);
    }
}
