using Xunit;
using Moq;
using MS.Application.Services;
using MS.Infrastructure.Repositories.UnitOfWork;
using MS.Application.DTOs.Lab;
using MS.Data.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;
using MS.Data.Enums;

namespace MS.Application.Tests.Services
{
    public class LabServiceTests
    {
        private readonly LabService _labService;
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;

        public LabServiceTests()
        {
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _labService = new LabService(_unitOfWorkMock.Object);
        }

        [Fact]
        public async Task CreateLabAsync_ValidModel_ReturnsCreatedResponse()
        {
            // Arrange
            var model = new CreateLabDto { Name = "Test Name", HospitalID = 1, Type = LabType.Lab };
            var lab = new Lab { Name = model.Name, HospitalID = model.HospitalID, Type = model.Type };

            _unitOfWorkMock.Setup(u => u.Labs.AddAsync(It.IsAny<Lab>())).ReturnsAsync(lab);

            // Act
            var response = await _labService.CreateLabAsync(model);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("Entity created", response.Message);
            Assert.NotNull(response.Data);
        }

        [Fact]
        public async Task DeleteLabAsync_ValidId_ReturnsDeletedResponse()
        {
            // Arrange
            var id = 1;
            var lab = new Lab { ID = id, Name = "Test Name", HospitalID = 1, Type = LabType.XRay };

            _unitOfWorkMock.Setup(u => u.Labs.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(lab);
            _unitOfWorkMock.Setup(u => u.Labs.DeleteAsync(It.IsAny<Lab>())).Returns(Task.CompletedTask);

            // Act
            var response = await _labService.DeleteLabAsync(id);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("Deleted Successfully", response.Message);
        }

        [Fact]
        public async Task GetLabAsync_ValidId_ReturnsLab()
        {
            // Arrange
            var id = 1;
            var lab = new Lab { ID = id, Name = "Test Name", HospitalID = 1, Type = LabType.Lab };

            _unitOfWorkMock.Setup(u => u.Labs.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(lab);

            // Act
            var response = await _labService.GetLabAsync(id);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("succeeded process", response.Message);
            Assert.NotNull(response.Data);
        }

        [Fact]
        public async Task UpdateLabAsync_ValidModel_ReturnsUpdatedResponse()
        {
            // Arrange
            var model = new UpdateLabDto { ID = 1, Name = "Updated Name", HospitalID = 1, Type = LabType.XRay };
            var lab = new Lab { ID = model.ID, Name = model.Name, HospitalID = model.HospitalID, Type = model.Type };

            _unitOfWorkMock.Setup(u => u.Labs.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(lab);
            _unitOfWorkMock.Setup(u => u.Labs.UpdateAsync(It.IsAny<Lab>())).Returns(Task.CompletedTask);

            // Act
            var response = await _labService.UpdateLabAsync(model);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("succeeded process", response.Message);
            Assert.NotNull(response.Data);
        }

        [Fact]
        public async Task GetLabsAsync_ReturnsLabs()
        {
            // Arrange
            var labs = new List<Lab> { new Lab { ID = 1, Name = "Test Name", HospitalID = 1, Type = LabType.Lab } };

            _unitOfWorkMock.Setup(u => u.Labs.GetAllAsync()).ReturnsAsync(labs);

            // Act
            var response = await _labService.GetLabsAsync();

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("succeeded process", response.Message);
            Assert.NotNull(response.Data);
        }
    }
}