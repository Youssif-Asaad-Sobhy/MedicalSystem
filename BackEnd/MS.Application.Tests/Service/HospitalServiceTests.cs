using Xunit;
using Moq;
using MS.Application.Services;
using MS.Infrastructure.Repositories.UnitOfWork;
using MS.Application.DTOs.Hospital;
using MS.Data.Entities;
using System.Threading.Tasks;
using MS.Data.Enums;

namespace MS.Application.Tests.Services
{
    public class HospitalServiceTests
    {
        private readonly HospitalService _hospitalService;
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;

        public HospitalServiceTests()
        {
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _hospitalService = new HospitalService(_unitOfWorkMock.Object);
        }

        [Fact]
        public async Task CreateHospitalAsync_ValidModel_ReturnsCreatedResponse()
        {
            // Arrange
            var model = new CreateHospitalDto { Name = "Test Name", City = "Test City", Country = "Test Country", Government = "Test Government", Phone = "Test Phone", Type = HospitalType.Private };
            var hospital = new Hospital { Name = model.Name, City = model.City, Country = model.Country, Government = model.Government, Phone = model.Phone, Type = model.Type };

            _unitOfWorkMock.Setup(u => u.Hospitals.AddAsync(It.IsAny<Hospital>())).ReturnsAsync(hospital);

            // Act
            var response = await _hospitalService.CreateHospitalAsync(model);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("Entity created", response.Message);
            Assert.NotNull(response.Data);
        }

        [Fact]
        public async Task DeleteHospitalAsync_ValidId_ReturnsDeletedResponse()
        {
            // Arrange
            var id = 1;
            var hospital = new Hospital { ID = id, Name = "Test Name", City = "Test City", Country = "Test Country", Government = "Test Government", Phone = "Test Phone", Type = HospitalType.Public };

            _unitOfWorkMock.Setup(u => u.Hospitals.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(hospital);
            _unitOfWorkMock.Setup(u => u.Hospitals.DeleteAsync(It.IsAny<Hospital>())).Returns(Task.CompletedTask);

            // Act
            var response = await _hospitalService.DeleteHospitalAsync(id);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("Deleted Successfully", response.Message);
        }

        [Fact]
        public async Task GetHospitalAsync_ValidId_ReturnsHospital()
        {
            // Arrange
            var id = 1;
            var hospital = new Hospital { ID = id, Name = "Test Name", City = "Test City", Country = "Test Country", Government = "Test Government", Phone = "Test Phone", Type = HospitalType.Private };

            _unitOfWorkMock.Setup(u => u.Hospitals.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(hospital);

            // Act
            var response = await _hospitalService.GetHospitalAsync(id);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("succeeded process", response.Message);
            Assert.NotNull(response.Data);
        }

        [Fact]
        public async Task UpdateHospitalAsync_ValidModel_ReturnsUpdatedResponse()
        {
            // Arrange
            var model = new UpdateHospitalDto { ID = 1, Name = "Updated Name", City = "Updated City", Country = "Updated Country", Government = "Updated Government", Phone = "Updated Phone", Type = HospitalType.Public };
            var hospital = new Hospital { ID = model.ID, Name = model.Name, City = model.City, Country = model.Country, Government = model.Government, Phone = model.Phone, Type = model.Type };

            _unitOfWorkMock.Setup(u => u.Hospitals.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(hospital);
            _unitOfWorkMock.Setup(u => u.Hospitals.UpdateAsync(It.IsAny<Hospital>())).Returns(Task.CompletedTask);

            // Act
            var response = await _hospitalService.UpdateHospitalAsync(model);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("succeeded process", response.Message);
            Assert.NotNull(response.Data);
        }
    }
}