using Xunit;
using Moq;
using MS.Application.Services;
using MS.Infrastructure.Repositories.UnitOfWork;
using MS.Application.DTOs.Pharmacy;
using MS.Data.Entities;
using System.Threading.Tasks;

namespace MS.Application.Tests.Services
{
    public class PharmacyServiceTests
    {
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;
        private readonly PharmacyService _pharmacyService;

        public PharmacyServiceTests()
        {
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _pharmacyService = new PharmacyService(_unitOfWorkMock.Object);
        }

        [Fact]
        public async Task CreatePharmacyAsync_ValidModel_ReturnsCreatedResponse()
        {
            // Arrange
            var model = new CreatePharmacyDto { Name = "Test Pharmacy", HospitalID = 1 };
            var pharmacy = new Pharmacy { Name = model.Name, HospitalID = model.HospitalID };

            _unitOfWorkMock.Setup(u => u.Pharmacies.AddAsync(It.IsAny<Pharmacy>())).ReturnsAsync(pharmacy);

            // Act
            var response = await _pharmacyService.CreatePharmacyAsync(model);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("Entity created", response.Message);
            Assert.NotNull(response.Data);
        }

        [Fact]
        public async Task DeletePharmacyAsync_ValidId_ReturnsDeletedResponse()
        {
            // Arrange
            var pharmacy = new Pharmacy { ID = 1, Name = "Test Pharmacy", HospitalID = 1 };

            _unitOfWorkMock.Setup(u => u.Pharmacies.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(pharmacy);
            _unitOfWorkMock.Setup(u => u.Pharmacies.DeleteAsync(It.IsAny<Pharmacy>())).Returns(Task.CompletedTask);

            // Act
            var response = await _pharmacyService.DeletePharmacyAsync(pharmacy.ID);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("Deleted Successfully", response.Message);
        }

        [Fact]
        public async Task GetPharmacyAsync_ValidId_ReturnsPharmacy()
        {
            // Arrange
            var pharmacy = new Pharmacy { ID = 1, Name = "Test Pharmacy", HospitalID = 1 };

            _unitOfWorkMock.Setup(u => u.Pharmacies.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(pharmacy);

            // Act
            var response = await _pharmacyService.GetPharmacyAsync(pharmacy.ID);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("succeeded process", response.Message);
            Assert.NotNull(response.Data);
        }

        [Fact]
        public async Task UpdatePharmacyAsync_ValidModel_ReturnsUpdatedResponse()
        {
            // Arrange
            var model = new UpdatePharmacyDto { ID = 1, Name = "Updated Test Pharmacy", HospitalID = 1 };
            var pharmacy = new Pharmacy { ID = model.ID, Name = model.Name, HospitalID = model.HospitalID };

            _unitOfWorkMock.Setup(u => u.Pharmacies.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(pharmacy);
            _unitOfWorkMock.Setup(u => u.Pharmacies.UpdateAsync(It.IsAny<Pharmacy>())).Returns(Task.CompletedTask);

            // Act
            var response = await _pharmacyService.UpdatePharmacyAsync(model);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("succeeded process", response.Message);
            Assert.NotNull(response.Data);
        }
    }
}