using Xunit;
using Moq;
using MS.Application.Services;
using MS.Infrastructure.Repositories.UnitOfWork;
using MS.Application.DTOs.Clinc;
using MS.Data.Entities;
using System;
using System.Linq.Expressions;

namespace MS.Application.Tests.Services
{
    public class ClinicServiceTests
    {
        private readonly ClinicService _clinicService;
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;

        public ClinicServiceTests()
        {
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _clinicService = new ClinicService(_unitOfWorkMock.Object);
        }

        [Fact]
        public async Task CreateClinicAsync_ValidModel_ReturnsCreatedResponse()
        {
            // Arrange
            var model = new CreateClinicDto { Name = "Test", DepartmentID = 1 };
            var clinic = new Clinic { Name = model.Name, DepartmentID = model.DepartmentID };

            _unitOfWorkMock.Setup(u => u.Clinics.AddAsync(It.IsAny<Clinic>())).ReturnsAsync(clinic);

            // Act
            var response = await _clinicService.CreateClinicAsync(model);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("Entity created", response.Message);
            Assert.NotNull(response.Data);
        }

        [Fact]
        public async Task DeleteClinicAsync_ValidId_ReturnsDeletedResponse()
        {
            // Arrange
            var id = 1;
            var clinic = new Clinic { ID = id };

            _unitOfWorkMock.Setup(u => u.Clinics.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(clinic);
            _unitOfWorkMock.Setup(u => u.Clinics.DeleteAsync(It.IsAny<Clinic>())).Returns(Task.CompletedTask);

            // Act
            var response = await _clinicService.DeleteClinicAsync(id);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("Deleted Successfully", response.Message);
        }

        [Fact]
        public async Task GetClinicAsync_ValidId_ReturnsClinic()
        {
            // Arrange
            var id = 1;
            var clinic = new Clinic { ID = id };

            _unitOfWorkMock.Setup(u => u.Clinics.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(clinic);

            // Act
            var response = await _clinicService.GetClinicAsync(id);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("succeeded process", response.Message);
            Assert.NotNull(response.Data);
        }

        [Fact]
        public async Task UpdateClinicAsync_ValidModel_ReturnsUpdatedResponse()
        {
            // Arrange
            var model = new UpdateClinicDto { ID = 1, Name = "Test", DepartmentID = 1 };
            var clinic = new Clinic { ID = model.ID, Name = model.Name, DepartmentID = model.DepartmentID };

            _unitOfWorkMock.Setup(u => u.Clinics.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(clinic);
            _unitOfWorkMock.Setup(u => u.Clinics.UpdateAsync(It.IsAny<Clinic>())).Returns(Task.CompletedTask);

            // Act
            var response = await _clinicService.UpdateClinicAsync(model);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("Updated Successfully", response.Message);
            Assert.NotNull(response.Data);
        }

        
        [Fact]
        public async Task GetAllClinicsWithDepartmentIdAsync_ValidDepartmentId_ReturnsClinics()
        {
            // Arrange
            var departmentId = 1;
            var clinics = new List<Clinic>
            {
                new Clinic { ID = 1, DepartmentID = departmentId },
                new Clinic { ID = 2, DepartmentID = departmentId }
            };

            _unitOfWorkMock.Setup(u => u.Clinics.GetAllAsync()).ReturnsAsync(clinics);

            // Act
            var response = await _clinicService.GetAllClinicsWithDepartmentIdAsync(departmentId);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("succeeded process", response.Message);
            Assert.NotNull(response.Data);
        }
    }
}
