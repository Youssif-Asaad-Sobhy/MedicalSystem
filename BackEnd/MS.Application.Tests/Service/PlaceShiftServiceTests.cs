using Xunit;
using Moq;
using MS.Application.DTOs.PlaceShift;
using MS.Data.Entities;
using MS.Infrastructure.Repositories.UnitOfWork;
using System.Threading.Tasks;
using MS.Application.Services;
using MS.Data.Enums;

namespace MS.Application.Tests.Services
{
    public class PlaceShiftServiceTests
    {
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;
        private readonly PlaceShiftService _placeShiftService;

        public PlaceShiftServiceTests()
        {
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _placeShiftService = new PlaceShiftService(_unitOfWorkMock.Object);
        }

        [Fact]
        public async Task CreatePlaceShiftAsync_ShouldReturnBadRequest_WhenModelIsNull()
        {
            var result = await _placeShiftService.CreatePlaceShiftAsync(null);
            Assert.Equal("PlaceShift model not found.", result.Message);
        }

        [Fact]
        public async Task DeletePlaceShiftAsync_ShouldReturnBadRequest_WhenPlaceShiftDoesNotExist()
        {
            _unitOfWorkMock.Setup(u => u.PlaceShifts.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((PlaceShift)null);

            var result = await _placeShiftService.DeletePlaceShiftAsync(1);
            Assert.Equal("PlaceShift with ID 1 not found.", result.Message);
        }

        [Fact]
        public async Task GetPlaceShiftAsync_ShouldReturnBadRequest_WhenPlaceShiftDoesNotExist()
        {
            _unitOfWorkMock.Setup(u => u.PlaceShifts.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((PlaceShift)null);

            var result = await _placeShiftService.GetPlaceShiftAsync(1);
            Assert.Equal("PlaceShift with ID 1 not found.", result.Message);
        }

        [Fact]
        public async Task UpdatePlaceShiftAsync_ShouldReturnBadRequest_WhenPlaceShiftDoesNotExist()
        {
            _unitOfWorkMock.Setup(u => u.PlaceShifts.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((PlaceShift)null);

            var result = await _placeShiftService.UpdatePlaceShiftAsync(new UpdatePlaceShiftDto { ID = 1 });
            Assert.Equal("PlaceShift with ID 1 not found.", result.Message);
        }

        [Fact]
        public async Task CreatePlaceShiftAsync_ShouldReturnCreated_WhenModelIsValid()
        {
            var model = new CreatePlaceShiftDto { EntityID = 1, PlaceType = PlaceType.Clinic, ShiftID = 1 };
            _unitOfWorkMock.Setup(u => u.PlaceShifts.AddAsync(It.IsAny<PlaceShift>())).Returns(Task.FromResult(new PlaceShift()));

            var result = await _placeShiftService.CreatePlaceShiftAsync(model);

            Assert.Equal("Entity created", result.Message);
        }

        [Fact]
        public async Task DeletePlaceShiftAsync_ShouldReturnDeleted_WhenPlaceShiftExists()
        {
            var placeShift = new PlaceShift { ID = 1, EntityID = 1, PlaceType = PlaceType.Clinic, ShiftID = 1 };
            _unitOfWorkMock.Setup(u => u.PlaceShifts.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(placeShift);
            _unitOfWorkMock.Setup(u => u.PlaceShifts.DeleteAsync(It.IsAny<PlaceShift>())).Returns(Task.CompletedTask);

            var result = await _placeShiftService.DeletePlaceShiftAsync(1);

            Assert.Equal("Deleted Successfully", result.Message);
        }

        [Fact]
        public async Task GetPlaceShiftAsync_ShouldReturnSuccess_WhenPlaceShiftExists()
        {
            var placeShift = new PlaceShift { ID = 1, EntityID = 1, PlaceType = PlaceType.Clinic, ShiftID = 1 };
            _unitOfWorkMock.Setup(u => u.PlaceShifts.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(placeShift);

            var result = await _placeShiftService.GetPlaceShiftAsync(1);

            Assert.Equal("succeeded process", result.Message);
            Assert.Equal(placeShift, result.Data);
        }

        [Fact]
        public async Task UpdatePlaceShiftAsync_ShouldReturnSuccess_WhenPlaceShiftExistsAndModelIsValid()
        {
            var placeShift = new PlaceShift { ID = 1, EntityID = 1, PlaceType = PlaceType.Clinic, ShiftID = 1 };
            var model = new UpdatePlaceShiftDto { ID = 1, EntityID = 2, PlaceType = PlaceType.Clinic, ShiftID = 2 };
            _unitOfWorkMock.Setup(u => u.PlaceShifts.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(placeShift);

            var result = await _placeShiftService.UpdatePlaceShiftAsync(model);

            Assert.Equal("Updated Successfully", result.Message);
            Assert.Equal(model.EntityID, result.Data.EntityID);
            Assert.Equal(model.PlaceType, result.Data.PlaceType);
            Assert.Equal(model.ShiftID, result.Data.ShiftID);
        }
    }
}