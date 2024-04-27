using Xunit;
using Moq;
using MS.Application.Services;
using MS.Infrastructure.Repositories.UnitOfWork;
using MS.Application.DTOs.PharmacyMedicine;
using MS.Data.Entities;
using System.Threading.Tasks;

namespace MS.Application.Tests.Services
{
    public class PharmacyMedicineServiceTests
    {
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;
        private readonly PharmacyMedicineService _pharmacyMedicineService;

        public PharmacyMedicineServiceTests()
        {
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _pharmacyMedicineService = new PharmacyMedicineService(_unitOfWorkMock.Object);
        }
        [Fact]
        public async Task CreatePharmacyMedicineAsync_ValidModel_ReturnsCreatedResponse()
        {
            // Arrange
            var model = new CreatePharmacyMedicineDto
            { PharmacyID = 1, MedicineTypeID = 1, Amount = 10, Price = 20.5 };
            var pharmacyMedicine = new PharmacyMedicine
            { PharmacyID = model.PharmacyID, MedicineTypeID = model.MedicineTypeID, Amount = model.Amount, Price = model.Price };
            _unitOfWorkMock.Setup(u => u.PharmacyMedicines.AddAsync(It.IsAny<PharmacyMedicine>())).ReturnsAsync(pharmacyMedicine);
            // Act
            var response = await _pharmacyMedicineService.CreatePharmacyMedicineAsync(model);
            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("Entity created", response.Message);
            Assert.NotNull(response.Data);
        }        
        [Fact]
        public async Task DeletePharmacyMedicineAsync_ShouldReturnDeletedPharmacyMedicine_WhenIdIsValid()
        {
            // Arrange
            var pharmacyMedicine = new PharmacyMedicine { ID = 1 };
            _unitOfWorkMock.Setup(u => u.PharmacyMedicines.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(pharmacyMedicine);

            // Act
            var result = await _pharmacyMedicineService.DeletePharmacyMedicineAsync(pharmacyMedicine.ID);

            // Assert
            Assert.Equal("Deleted Successfully", result.Message);
        }

        [Fact]
        public async Task GetPharmacyMedicineAsync_ShouldReturnPharmacyMedicine_WhenIdIsValid()
        {
            // Arrange
            var pharmacyMedicine = new PharmacyMedicine { ID = 1 };
            _unitOfWorkMock.Setup(u => u.PharmacyMedicines.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(pharmacyMedicine);

            // Act
            var result = await _pharmacyMedicineService.GetPharmacyMedicineAsync(pharmacyMedicine.ID);

            // Assert
            Assert.Equal(pharmacyMedicine, result.Data);
        }

        [Fact]
        public async Task UpdatePharmacyMedicineAsync_ShouldReturnUpdatedPharmacyMedicine_WhenModelIsValid()
        {
            // Arrange
            var model = new UpdatePharmacyMedicineDto { ID = 1, PharmacyID = 1, MedicineTypeID = 1, Amount = 10, Price = 100.0 };
            var pharmacyMedicine = new PharmacyMedicine { ID = model.ID, PharmacyID = model.PharmacyID, MedicineTypeID = model.MedicineTypeID, Amount = model.Amount, Price = model.Price };

            _unitOfWorkMock.Setup(u => u.PharmacyMedicines.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(pharmacyMedicine);
            _unitOfWorkMock.Setup(u => u.PharmacyMedicines.UpdateAsync(It.IsAny<PharmacyMedicine>())).Returns(Task.FromResult(pharmacyMedicine));

            // Act
            var result = await _pharmacyMedicineService.UpdatePharmacyMedicineAsync(model);

            // Assert
            Assert.Equal(pharmacyMedicine, result.Data);
        }
    }
}