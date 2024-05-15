using Xunit;
using Moq;
using MS.Application.Services;
using MS.Infrastructure.Repositories.UnitOfWork;
using MS.Application.DTOs.MedicineType;
using MS.Data.Entities;
using System;

namespace MS.Application.Tests.Services
{
    public class MedicineTypeServiceTests
    {
        private readonly MedicineTypeService _medicineTypeService;
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;

        public MedicineTypeServiceTests()
        {
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _medicineTypeService = new MedicineTypeService(_unitOfWorkMock.Object);
        }

        [Fact]
        public async Task CreateMedicineTypeAsync_ValidModel_ReturnsCreatedResponse()
        {
            // Arrange
            var model = new CreateMedicineTypeDto
            {
                MedicineID = 1, TypeID = 1, Description = "Test", ExpirationDate = DateTime.Now, SideEffects = "None",
                Warning = "None"
            };
            var medicineType = new MedicineType
            {
                MedicineID = model.MedicineID, TypeID = model.TypeID, Description = model.Description,
                ExpirationDate = model.ExpirationDate, SideEffects = model.SideEffects, Warning = model.Warning
            };

            _unitOfWorkMock.Setup(u => u.MedicineTypes.AddAsync(It.IsAny<MedicineType>())).ReturnsAsync(medicineType);

            // Act
            var response = await _medicineTypeService.CreateMedicineTypeAsync(model);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("Entity created", response.Message);
            Assert.NotNull(response.Data);
        }

        [Fact]
        public async Task DeleteMedicineTypeAsync_ValidId_ReturnsDeletedResponse()
        {
            // Arrange
            var id = 1;
            var medicineType = new MedicineType { ID = id };

            _unitOfWorkMock.Setup(u => u.MedicineTypes.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(medicineType);
            _unitOfWorkMock.Setup(u => u.MedicineTypes.DeleteAsync(It.IsAny<MedicineType>()))
                .Returns(Task.CompletedTask);

            // Act
            var response = await _medicineTypeService.DeleteMedicineTypeAsync(id);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("Deleted Successfully", response.Message);
        }

        [Fact]
        public async Task GetMedicineTypeAsync_ValidId_ReturnsMedicineType()
        {
            // Arrange
            var id = 1;
            var medicineType = new MedicineType { ID = id };

            _unitOfWorkMock.Setup(u => u.MedicineTypes.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(medicineType);

            // Act
            var response = await _medicineTypeService.GetMedicineTypeAsync(id);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("succeeded process", response.Message);
            Assert.NotNull(response.Data);
        }

        [Fact]
        public async Task UpdateMedicineTypeAsync_ValidModel_ReturnsUpdatedResponse()
        {
            // Arrange
            var model = new UpdateMedicineTypeDto
            {
                ID = 1, MedicineID = 1, TypeID = 1, Description = "Test", ExpirationDate = DateTime.Now,
                SideEffects = "None", Warning = "None"
            };
            var medicineType = new MedicineType
            {
                ID = model.ID, MedicineID = model.MedicineID, TypeID = model.TypeID, Description = model.Description,
                ExpirationDate = model.ExpirationDate, SideEffects = model.SideEffects, Warning = model.Warning
            };

            _unitOfWorkMock.Setup(u => u.MedicineTypes.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(medicineType);
            _unitOfWorkMock.Setup(u => u.MedicineTypes.UpdateAsync(It.IsAny<MedicineType>()))
                .Returns(Task.CompletedTask);

            // Act
            var response = await _medicineTypeService.UpdateMedicineTypeAsync(model);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("succeeded process", response.Message);
            Assert.NotNull(response.Data);
        }
    }
}