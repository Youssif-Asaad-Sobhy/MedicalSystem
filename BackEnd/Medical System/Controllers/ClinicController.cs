using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MS.Data.Entities;
using MS.Infrastructure.Repositories.UnitOfWork;

namespace Medical_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClinicController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ClinicController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet("{ClinicID}")]
        public async Task<Clinic> GetSingleClincAsync(int ClinicID)
        {
            return await  _unitOfWork.Clinincs.GetByIdAsync(ClinicID);
        }
        [HttpDelete("{ClinicID}")]
        public async Task DeleteSingleAsync(int ClinicID)
        {
            await _unitOfWork.Clinincs.DeleteAsync(await _unitOfWork.Clinincs.GetByIdAsync(ClinicID));
        }
        [HttpPost]
        public async Task PostSingleAsync(int departmentID,string name)
        {
            Clinic clinic = new Clinic() {
                DepartmentID = departmentID,
                Name=name
            };
            await _unitOfWork.Clinincs.AddAsync(clinic);
        }
        [HttpPut("{ClinicID}")]
        public async Task PutSingleAsync(int ClinicID,string? name)
        {
            Clinic OldClinic = await _unitOfWork.Clinincs.GetByIdAsync(ClinicID);
            Clinic clinic = new Clinic()
            {
                ID = ClinicID,
                Name = name is not null ? name : OldClinic.Name,
            };
            await _unitOfWork.Clinincs.UpdateAsync(clinic);
        }

    }
}
