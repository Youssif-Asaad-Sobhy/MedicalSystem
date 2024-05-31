using Xunit;
using Moq;
using MS.Application.Services;
using MS.Infrastructure.Repositories.UnitOfWork;
using MS.Application.DTOs.Department;
using MS.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using MS.Application.Interfaces;

namespace MS.Application.Tests.Services
{
    public class DepartmentServiceTests
    {
        private readonly DepartmentService _departmentService;
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;
        private readonly IFilter<Department> _filter;

        public DepartmentServiceTests(Mock<IUnitOfWork> mock , IFilter<Department> filter)
        {
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _filter = filter;
            _departmentService = new DepartmentService(_unitOfWorkMock.Object,_filter);
        }

        [Fact]
        public async Task CreateDepartmentAsync_ValidModel_ReturnsCreatedResponse()
        {
            // Arrange
            var model = new CreateDeptDto { Name = "Test", HospitalID = 1 };
            var department = new Department { Name = model.Name, HospitalID = model.HospitalID };

            _unitOfWorkMock.Setup(u => u.Departments.AddAsync(It.IsAny<Department>())).ReturnsAsync(department);

            // Act
            var response = await _departmentService.CreateDepartmentAsync(model);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("Entity created", response.Message);
            Assert.NotNull(response.Data);
        }

        [Fact]
        public async Task DeleteDepartmentAsync_ValidId_ReturnsDeletedResponse()
        {
            // Arrange
            var id = 1;
            var department = new Department { ID = id };

            _unitOfWorkMock.Setup(u => u.Departments.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(department);
            _unitOfWorkMock.Setup(u => u.Departments.DeleteAsync(It.IsAny<Department>())).Returns(Task.CompletedTask);

            // Act
            var response = await _departmentService.DeleteDepartmentAsync(id);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("Deleted Successfully", response.Message);
        }

        [Fact]
        public async Task GetAllDepartmentsAsync_ReturnsAllDepartments()
        {
            // Arrange
            var departments = new List<Department>
            {
                new Department { ID = 1, Name = "Test1", HospitalID = 1 },
                new Department { ID = 2, Name = "Test2", HospitalID = 2 }
            };

            _unitOfWorkMock.Setup(u => u.Departments.GetAllAsync()).ReturnsAsync(departments);

            // Act
            var response = await _departmentService.GetAllDepartmentsAsync();

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("succeeded process", response.Message);
            Assert.NotNull(response.Data);
            Assert.Equal(2, response.Data.Count());
        }

        [Fact]
        public async Task GetDepartmentByIDAsync_ValidId_ReturnsDepartment()
        {
            // Arrange
            var id = 1;
            var department = new Department { ID = id, Name = "Test", HospitalID = 1 };

            _unitOfWorkMock.Setup(u => u.Departments.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(department);

            // Act
            var response = await _departmentService.GetDepartmentByIDAsync(id);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("succeeded process", response.Message);
            Assert.NotNull(response.Data);
        }

        [Fact]
        public async Task UpdateDepartmentAsync_ValidModel_ReturnsUpdatedResponse()
        {
            // Arrange
            var model = new UpdateDeptDto { ID = 1, Name = "Test Updated", HospitalID = 1 };
            var department = new Department { ID = model.ID, Name = model.Name, HospitalID = model.HospitalID };

            _unitOfWorkMock.Setup(u => u.Departments.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(department);
            _unitOfWorkMock.Setup(u => u.Departments.UpdateAsync(It.IsAny<Department>())).Returns(Task.CompletedTask);

            // Act
            var response = await _departmentService.UpdateDepartmentAsync(model);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("succeeded process", response.Message);
            Assert.NotNull(response.Data);
        }
    }
}