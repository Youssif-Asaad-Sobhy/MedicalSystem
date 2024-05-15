using Moq;
using MS.Data.Entities;
using MS.Data.Enums;
using MS.Infrastructure.Repositories.UnitOfWork;
using MS.Application.Services;
using MS.Application.DTOs.ClinicPrice;
using System.Linq.Expressions;

namespace MS.Application.Tests.Services
{
    public class PlacePriceServiceTests
    {
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;
        private readonly PlacePriceService _placePriceService;

        public PlacePriceServiceTests()
        {
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _placePriceService = new PlacePriceService(_unitOfWorkMock.Object);
        }

        [Fact]
        public async Task CreatePlacePriceAsync_ShouldReturnBadRequest_WhenModelIsNull()
        {
            var result = await _placePriceService.CreatePlacePriceAsync(null);
            Assert.Equal("ClinicPrice model not found.", result.Message);
        }

        [Fact]
        public async Task DeletePlacePriceAsync_ShouldReturnBadRequest_WhenPlacePriceDoesNotExist()
        {
            _unitOfWorkMock.Setup(u => u.PlacePrice.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((PlacePrice)null);

            var result = await _placePriceService.DeletePlacePriceAsync(1);
            Assert.Equal("ClinicPrice with ID 1 not found.", result.Message);
        }

        [Fact]
        public async Task GetPlacePriceAsync_ShouldReturnBadRequest_WhenPlacePriceDoesNotExist()
        {
            _unitOfWorkMock.Setup(u => u.PlacePrice.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((PlacePrice)null);

            var result = await _placePriceService.GetPlacePriceAsync(1);
            Assert.Equal("ClinicPrice with ID 1 not found.", result.Message);
        }

        [Fact]
        public async Task UpdatePlacePriceAsync_ShouldReturnBadRequest_WhenPlacePriceDoesNotExist()
        {
            _unitOfWorkMock.Setup(u => u.PlacePrice.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((PlacePrice)null);

            var result = await _placePriceService.UpdatePlacePriceAsync(new UpdatePlacePriceDto { ID = 1 });
            Assert.Equal("ClinicPrice with ID 1 not found.", result.Message);
        }

        [Fact]
        public async Task CreatePlacePriceAsync_ShouldReturnCreated_WhenModelIsValid()
        {
            var model = new CreatePlacePriceDto { Name = "Test", Price = 100, PlaceType = PlaceType.Clinic, PlaceID = 1 };
            _unitOfWorkMock.Setup(u => u.PlacePrice.AddAsync(It.IsAny<PlacePrice>())).Returns(Task.FromResult(new PlacePrice()));

            var result = await _placePriceService.CreatePlacePriceAsync(model);

            Assert.Equal("Entity created", result.Message);
        }

        [Fact]
        public async Task DeletePlacePriceAsync_ShouldReturnDeleted_WhenPlacePriceExists()
        {
            var placePrice = new PlacePrice { ID = 1, Name = "Test", Price = 100, PlaceType = PlaceType.Clinic, PlaceID = 1 };
            _unitOfWorkMock.Setup(u => u.PlacePrice.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(placePrice);
            _unitOfWorkMock.Setup(u => u.PlacePrice.DeleteAsync(It.IsAny<PlacePrice>())).Returns(Task.CompletedTask);

            var result = await _placePriceService.DeletePlacePriceAsync(1);

            Assert.Equal("Deleted Successfully", result.Message);
        }

        [Fact]
        public async Task GetPlacePriceAsync_ShouldReturnSuccess_WhenPlacePriceExists()
        {
            var placePrice = new PlacePrice { ID = 1, Name = "Test", Price = 100, PlaceType = PlaceType.Clinic, PlaceID = 1 };
            _unitOfWorkMock.Setup(u => u.PlacePrice.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(placePrice);

            var result = await _placePriceService.GetPlacePriceAsync(1);

            Assert.Equal("succeeded process", result.Message);
            Assert.Equal(placePrice, result.Data);
        }

        [Fact]
        public async Task UpdatePlacePriceAsync_ShouldReturnSuccess_WhenPlacePriceExistsAndModelIsValid()
        {
            var placePrice = new PlacePrice { ID = 1, Name = "Test", Price = 100, PlaceType = PlaceType.Clinic, PlaceID = 1 };
            var model = new UpdatePlacePriceDto { ID = 1, Name = "Updated", Price = 200, PlaceType = PlaceType.Clinic, PlaceID = 2 };
            _unitOfWorkMock.Setup(u => u.PlacePrice.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(placePrice);

            var result = await _placePriceService.UpdatePlacePriceAsync(model);

            Assert.Equal("Updated Successfully", result.Message);
            Assert.Equal(model.Name, result.Data.Name);
            Assert.Equal(model.Price, result.Data.Price);
            Assert.Equal(model.PlaceType, result.Data.PlaceType);
            Assert.Equal(model.PlaceID, result.Data.PlaceID);
        }
        [Fact]
        public async Task GetAllPlacePricesAsync_ShouldReturnBadRequest_WhenNoPlacePricesExist()
        {
            _unitOfWorkMock.Setup(u => u.PlacePrice.GetByExpressionAsync(It.IsAny<Expression<Func<PlacePrice, bool>>>(), It.IsAny<Expression<Func<PlacePrice, object>>[]>()))
                           .ReturnsAsync(new List<PlacePrice>());

            var result = await _placePriceService.GetAllPlacePricesAsync(PlaceType.Clinic, 1);

            Assert.Equal("placeId or placeType is wrong or there is not prices for this place", result.Message);
        }   
            
        [Fact]
        public async Task GetAllPlacePricesAsync_ShouldReturnSuccess_WhenPlacePricesExist()
        {       
            var placePrices = new List<PlacePrice> { new PlacePrice { ID = 1, Name = "Test", Price = 100, PlaceType = PlaceType.Clinic, PlaceID = 1 } };
            _unitOfWorkMock.Setup(u => u.PlacePrice.GetByExpressionAsync(It.IsAny<Expression<Func<PlacePrice, bool>>>(), It.IsAny<Expression<Func<PlacePrice, object>>[]>()))
                            .ReturnsAsync(placePrices);
            var result = await _placePriceService.GetAllPlacePricesAsync(PlaceType.Clinic, 1);

            Assert.Equal("succeeded process", result.Message);
            Assert.Equal(placePrices, result.Data);
        }
    }
}