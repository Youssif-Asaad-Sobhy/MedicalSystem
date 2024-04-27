using Xunit;
using Moq;
using MS.Application.Services;
using MS.Infrastructure.Repositories.UnitOfWork;
using MS.Application.DTOs.Medicine;
using MS.Data.Entities;
using System;

namespace MS.Application.Tests.Services
{
    public class MedicineServiceTests
    {
        private readonly MedicineService _medicineService;
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;

        public MedicineServiceTests()
        {
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _medicineService = new MedicineService(_unitOfWorkMock.Object);
        }

        [Fact]
        public async Task CreateMedicineAsync_ValidModel_ReturnsCreatedResponse()
        {
            // Arrange
            var model = new CreateMedicineDto { Name = "Test" };
            var medicine = new Medicine { Name = model.Name };

            _unitOfWorkMock.Setup(u => u.Medicines.AddAsync(It.IsAny<Medicine>())).ReturnsAsync(medicine);

            // Act
            var response = await _medicineService.CreateMedicineAsync(model);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("Entity created", response.Message);
            Assert.NotNull(response.Data);
        }

        [Fact]
        public async Task DeleteMedicineAsync_ValidId_ReturnsDeletedResponse()
        {
            // Arrange
            var id = 1;
            var medicine = new Medicine { ID = id };

            _unitOfWorkMock.Setup(u => u.Medicines.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(medicine);
            _unitOfWorkMock.Setup(u => u.Medicines.DeleteAsync(It.IsAny<Medicine>())).Returns(Task.CompletedTask);

            // Act
            var response = await _medicineService.DeleteMedicineAsync(id);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("Deleted Successfully", response.Message);
        }

        [Fact]
        public async Task GetMedicineAsync_ValidId_ReturnsMedicine()
        {
            // Arrange
            var id = 1;
            var medicine = new Medicine { ID = id };

            _unitOfWorkMock.Setup(u => u.Medicines.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(medicine);

            // Act
            var response = await _medicineService.GetMedicineAsync(id);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("succeeded process", response.Message);
            Assert.NotNull(response.Data);
        }

        [Fact]
        public async Task UpdateMedicineAsync_ValidModel_ReturnsUpdatedResponse()
        {
            // Arrange
            var model = new UpdateMedicineDto { ID = 1, Name = "Test" };
            var medicine = new Medicine { ID = model.ID, Name = model.Name };

            _unitOfWorkMock.Setup(u => u.Medicines.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(medicine);
            _unitOfWorkMock.Setup(u => u.Medicines.UpdateAsync(It.IsAny<Medicine>())).Returns(Task.CompletedTask);

            // Act
            var response = await _medicineService.UpdateMedicineAsync(model);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("succeeded process", response.Message);
            Assert.NotNull(response.Data);
        }
    }
}