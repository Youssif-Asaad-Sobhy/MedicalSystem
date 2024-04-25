using Xunit;
using Moq;
using MS.Application.DTOs.PlaceEquipment;
using MS.Data.Entities;
using MS.Infrastructure.Repositories.UnitOfWork;
using System.Threading.Tasks;
using MS.Application.Services;
using MS.Data.Enums;

namespace MS.Application.Tests.Services
{
    public class PlaceEquipmentServiceTests
    {
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;
        private readonly PlaceEquipmentService _placeEquipmentService;

        public PlaceEquipmentServiceTests()
        {
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _placeEquipmentService = new PlaceEquipmentService(_unitOfWorkMock.Object);
        }

        [Fact]
        public async Task CreatePlaceEquipmentAsync_ShouldReturnBadRequest_WhenModelIsNull()
        {
            var result = await _placeEquipmentService.CreatePlaceEquipmentAsync(null);
            Assert.Equal("PlaceEquipment model not found.", result.Message);
        }

        [Fact]
        public async Task DeletePlaceEquipmentAsync_ShouldReturnBadRequest_WhenPlaceEquipmentDoesNotExist()
        {
            _unitOfWorkMock.Setup(u => u.PlaceEquipments.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((PlaceEquipment)null);

            var result = await _placeEquipmentService.DeletePlaceEquipmentAsync(1);
            Assert.Equal("PlaceEquipment with ID 1 not found.", result.Message);
        }

        [Fact]
        public async Task GetPlaceEquipmentAsync_ShouldReturnBadRequest_WhenPlaceEquipmentDoesNotExist()
        {
            _unitOfWorkMock.Setup(u => u.PlaceEquipments.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((PlaceEquipment)null);

            var result = await _placeEquipmentService.GetPlaceEquipmentAsync(1);
            Assert.Equal("PlaceEquipment with ID 1 not found.", result.Message);
        }

        [Fact]
        public async Task UpdatePlaceEquipmentAsync_ShouldReturnBadRequest_WhenPlaceEquipmentDoesNotExist()
        {
            _unitOfWorkMock.Setup(u => u.PlaceEquipments.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((PlaceEquipment)null);

            var result = await _placeEquipmentService.UpdatePlaceEquipmentAsync(new UpdatePlaceEquipmentDto { ID = 1 });
            Assert.Equal("PlaceEquipment with ID 1 not found.", result.Message);
        }

        [Fact]
        public async Task CreatePlaceEquipmentAsync_ShouldReturnCreated_WhenModelIsValid()
        {
            var model = new CreatePlaceEquipmentDto { EquipmentID = 1, PlaceType = PlaceType.Clinic, EntityID = 1 };
            _unitOfWorkMock.Setup(u => u.PlaceEquipments.AddAsync(It.IsAny<PlaceEquipment>())).Returns(Task.FromResult(new PlaceEquipment()));

            var result = await _placeEquipmentService.CreatePlaceEquipmentAsync(model);

            Assert.Equal("Entity created", result.Message);
        }

        [Fact]
        public async Task DeletePlaceEquipmentAsync_ShouldReturnDeleted_WhenPlaceEquipmentExists()
        {
            var placeEquipment = new PlaceEquipment { ID = 1, EquipmentID = 1, PlaceType = PlaceType.Clinic, EntityID = 1 };
            _unitOfWorkMock.Setup(u => u.PlaceEquipments.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(placeEquipment);
            _unitOfWorkMock.Setup(u => u.PlaceEquipments.DeleteAsync(It.IsAny<PlaceEquipment>())).Returns(Task.CompletedTask);

            var result = await _placeEquipmentService.DeletePlaceEquipmentAsync(1);

            Assert.Equal("Deleted Successfully", result.Message);
        }

        [Fact]
        public async Task GetPlaceEquipmentAsync_ShouldReturnSuccess_WhenPlaceEquipmentExists()
        {
            var placeEquipment = new PlaceEquipment { ID = 1, EquipmentID = 1, PlaceType = PlaceType.Clinic, EntityID = 1 };
            _unitOfWorkMock.Setup(u => u.PlaceEquipments.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(placeEquipment);

            var result = await _placeEquipmentService.GetPlaceEquipmentAsync(1);

            Assert.Equal("succeeded process", result.Message);
            Assert.Equal(placeEquipment, result.Data);
        }

        [Fact]
        public async Task UpdatePlaceEquipmentAsync_ShouldReturnSuccess_WhenPlaceEquipmentExistsAndModelIsValid()
        {
            var placeEquipment = new PlaceEquipment { ID = 1, EquipmentID = 1, PlaceType = PlaceType.Clinic, EntityID = 1 };
            var model = new UpdatePlaceEquipmentDto { ID = 1, EquipmentID = 2, PlaceType = PlaceType.Lab, EntityID = 2 };
            _unitOfWorkMock.Setup(u => u.PlaceEquipments.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(placeEquipment);

            var result = await _placeEquipmentService.UpdatePlaceEquipmentAsync(model);

            Assert.Equal("Updated Successfully", result.Message);
            Assert.Equal(model.EquipmentID, result.Data.EquipmentID);
            Assert.Equal(model.PlaceType, result.Data.PlaceType);
            Assert.Equal(model.EntityID, result.Data.EntityID);
        }
    }
}