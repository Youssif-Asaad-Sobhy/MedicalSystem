using Xunit;
using Moq;
using MS.Application.DTOs.Shift;
using MS.Data.Entities;
using MS.Infrastructure.Repositories.UnitOfWork;
using System.Threading.Tasks;
using MS.Application.Services;
using MS.Data.Enums;

namespace MS.Application.Tests.Services
{
    public class ShiftServiceTests
    {
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;
        private readonly ShiftService _shiftService;

        public ShiftServiceTests()
        {
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _shiftService = new ShiftService(_unitOfWorkMock.Object);
        }

        [Fact]
        public async Task CreateShiftAsync_ShouldReturnBadRequest_WhenModelIsNull()
        {
            var result = await _shiftService.CreateShiftAsync(null);
            Assert.Equal("Shift model not found.", result.Message);
        }

        [Fact]
        public async Task DeleteShiftAsync_ShouldReturnBadRequest_WhenShiftDoesNotExist()
        {
            _unitOfWorkMock.Setup(u => u.Shifts.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((Shift)null);

            var result = await _shiftService.DeleteShiftAsync(1);
            Assert.Equal("Shift with ID 1 not found.", result.Message);
        }

        [Fact]
        public async Task GetShiftAsync_ShouldReturnBadRequest_WhenShiftDoesNotExist()
        {
            _unitOfWorkMock.Setup(u => u.Shifts.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((Shift)null);

            var result = await _shiftService.GetShiftAsync(1);
            Assert.Equal("Shift with ID 1 not found.", result.Message);
        }

        [Fact]
        public async Task UpdateShiftAsync_ShouldReturnBadRequest_WhenShiftDoesNotExist()
        {
            _unitOfWorkMock.Setup(u => u.Shifts.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((Shift)null);

            var result = await _shiftService.UpdateShiftAsync(new UpdateShiftDto { ID = 1 });
            Assert.Equal("Shift with ID 1 not found.", result.Message);
        }

        [Fact]
        public async Task CreateShiftAsync_ShouldReturnCreated_WhenModelIsValid()
        {
            var model = new CreateShiftDto { Name = "Test", EntityID = 1, };
            _unitOfWorkMock.Setup(u => u.Shifts.AddAsync(It.IsAny<Shift>())).Returns(Task.FromResult(new Shift()));

            var result = await _shiftService.CreateShiftAsync(model);

            Assert.Equal("Entity created", result.Message);
        }

        [Fact]
        public async Task DeleteShiftAsync_ShouldReturnDeleted_WhenShiftExists()
        {
            var shift = new Shift { ID = 1, Name = "Test", EntityID = 1, PlaceType = PlaceType.Clinic};
            _unitOfWorkMock.Setup(u => u.Shifts.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(shift);
            _unitOfWorkMock.Setup(u => u.Shifts.DeleteAsync(It.IsAny<Shift>())).Returns(Task.CompletedTask);

            var result = await _shiftService.DeleteShiftAsync(1);

            Assert.Equal("Deleted Successfully", result.Message);
        }

        [Fact]
        public async Task GetShiftAsync_ShouldReturnSuccess_WhenShiftExists()
        {
            var shift = new Shift { ID = 1, Name = "Test", EntityID = 1, PlaceType = PlaceType.Lab};
            _unitOfWorkMock.Setup(u => u.Shifts.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(shift);

            var result = await _shiftService.GetShiftAsync(1);

            Assert.Equal("succeeded process", result.Message);
            Assert.Equal(shift, result.Data);
        }

        [Fact]
        public async Task UpdateShiftAsync_ShouldReturnSuccess_WhenShiftExistsAndModelIsValid()
        {
            var shift = new Shift { ID = 1, Name = "Test", EntityID = 1, PlaceType = PlaceType.Pharmacy };
            var model = new UpdateShiftDto { ID = 1, Name = "Updated", EntityID = 2, PlaceType = PlaceType.Clinic };
            _unitOfWorkMock.Setup(u => u.Shifts.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(shift);

            var result = await _shiftService.UpdateShiftAsync(model);

            Assert.Equal("Updated Successfully", result.Message);
            Assert.Equal(model.Name, result.Data.Name);
        }
    }
}