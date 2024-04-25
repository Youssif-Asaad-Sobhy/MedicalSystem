using Xunit;
using Moq;
using MS.Application.Services;
using MS.Infrastructure.Repositories.UnitOfWork;
using MS.Application.DTOs.Equipment;
using MS.Data.Entities;
using System.Threading.Tasks;

namespace MS.Application.Tests.Services
{
    public class EquipmentServiceTests
    {
        private readonly EquipmentService _equipmentService;
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;

        public EquipmentServiceTests()
        {
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _equipmentService = new EquipmentService(_unitOfWorkMock.Object);
        }

        [Fact]
        public async Task CreateEquipmentAsync_ValidModel_ReturnsCreatedResponse()
        {
            // Arrange
            var model = new CreateEquipmentDto { Description = "Test Description", Name = "Test Name" };
            var equipment = new Equipment { Description = model.Description, Name = model.Name };

            _unitOfWorkMock.Setup(u => u.Equipments.AddAsync(It.IsAny<Equipment>())).ReturnsAsync(equipment);

            // Act
            var response = await _equipmentService.CreateEquipmentAsync(model);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("Entity created", response.Message);
            Assert.NotNull(response.Data);
        }

        [Fact]
        public async Task DeleteEquipmentAsync_ValidId_ReturnsDeletedResponse()
        {
            // Arrange
            var id = 1;
            var equipment = new Equipment { ID = id, Description = "Test Description", Name = "Test Name" };

            _unitOfWorkMock.Setup(u => u.Equipments.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(equipment);
            _unitOfWorkMock.Setup(u => u.Equipments.DeleteAsync(It.IsAny<Equipment>())).Returns(Task.CompletedTask);

            // Act
            var response = await _equipmentService.DeleteEquipmentAsync(id);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("Deleted Successfully", response.Message);
        }

        [Fact]
        public async Task GetEquipmentAsync_ValidId_ReturnsEquipment()
        {
            // Arrange
            var id = 1;
            var equipment = new Equipment { ID = id, Description = "Test Description", Name = "Test Name" };

            _unitOfWorkMock.Setup(u => u.Equipments.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(equipment);

            // Act
            var response = await _equipmentService.GetEquipmentAsync(id);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("succeeded process", response.Message);
            Assert.NotNull(response.Data);
        }

        [Fact]
        public async Task UpdateEquipmentAsync_ValidModel_ReturnsUpdatedResponse()
        {
            // Arrange
            var model = new UpdateEquipmentDto { ID = 1, Description = "Updated Description", Name = "Updated Name" };
            var equipment = new Equipment { ID = model.ID, Description = model.Description, Name = model.Name };

            _unitOfWorkMock.Setup(u => u.Equipments.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(equipment);
            _unitOfWorkMock.Setup(u => u.Equipments.UpdateAsync(It.IsAny<Equipment>())).Returns(Task.CompletedTask);

            // Act
            var response = await _equipmentService.UpdateEquipmentAsync(model);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("succeeded process", response.Message);
            Assert.NotNull(response.Data);
        }
    }
}