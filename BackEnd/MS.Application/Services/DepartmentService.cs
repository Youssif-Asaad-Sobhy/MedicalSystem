using MS.Application.DTOs.Department;
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
using MS.Application.Helpers.Pagination;
namespace MS.Application.Services
{
    public class DepartmentService(IUnitOfWork unitOfWork) : IDepartmentService
    {
        private readonly IUnitOfWork _unitOfWork = unitOfWork;
        public async Task<Response<Department>> CreateDepartmentAsync(CreateDeptDto model)
        {
            if(model == null)
            {
                return ResponseHandler.BadRequest<Department>($"Department model not found.");
            }
            var Dept = new Department()
            {
                Name=model.Name,
                HospitalID=model.HospitalID
            };
            await _unitOfWork.Departments.AddAsync(Dept);
            return ResponseHandler.Created(Dept);
        }

        public async Task<Response<Department>> DeleteDepartmentAsync(int DeptID)
        {
            var dept = await _unitOfWork.Departments.GetByIdAsync(DeptID);
            if (dept is null || DeptID == 0)
            {
                return ResponseHandler.BadRequest<Department>("department model is null or not found");
            }
            await _unitOfWork.Departments.DeleteAsync(dept);
            return ResponseHandler.Deleted<Department>();
        }

        public async Task<Response<IEnumerable<Department>>> GetAllDepartmentsAsync(string[]? filter)
        {
            var deps = await _unitOfWork.Departments.GetAllFilteredAsync(filter);
            return ResponseHandler.Success(deps);
        }

        public async Task<Response<Department>> GetDepartmentByIDAsync(int ID)
        {
            var dept = await _unitOfWork.Departments.GetByIdAsync(ID);
            if (dept is null || ID == 0)
            {
                return ResponseHandler.BadRequest<Department>("department model is null or not found");
            }
            return ResponseHandler.Success<Department>(dept);
        }

        public async Task<Response<Department>> UpdateDepartmentAsync(UpdateDeptDto model)
        {
            var dept = await _unitOfWork.Departments.GetByIdAsync(model.ID);
            if (dept is null || model.ID == 0)
            {
                return ResponseHandler.BadRequest<Department>("department model is null or not found");
            }
            dept.Name = model.Name;
            dept.HospitalID = model.HospitalID;
            await _unitOfWork.Departments.UpdateAsync(dept);
            return ResponseHandler.Success(dept);
        }
        public async Task<PaginatedResult<List<DetailedDepartment>>> GetAllDepartmentAsync(string[]? filter, PageFilter? pageFilter, string? search = null)
        {
            var OutputList = new List<DetailedDepartment>();
            var departments = await _unitOfWork.Departments.GetAllFilteredAsync(filter);

            if (!search.IsNullOrEmpty())
            {
                departments = departments.Where(d => d.Name.Contains(search));
            }

            if (departments is null)
            {
                return ResponseHandler.BadRequest<List<DetailedDepartment>>(pageFilter, "Department model is null or not found");
            }

            foreach (Department department in departments)
            {
                var detailedDepartment = new DetailedDepartment()
                {
                    ID = department.ID,
                    Name = department.Name,
                    HospitalID = department.HospitalID,
                    Hospital = new DetailedHospital
                    {
                        // Fill in the properties of DetailedHospital based on the properties of department.Hospital
                    }
                };

                OutputList.Add(detailedDepartment);
            }

            var count = OutputList.Count();
            var detailedDepartments = OutputList.Skip((pageFilter.PageNumber - 1) * pageFilter.PageSize)
                .Take(pageFilter.PageSize).ToList();
            return ResponseHandler.Success(detailedDepartments, pageFilter, count);
        }
    }
}
