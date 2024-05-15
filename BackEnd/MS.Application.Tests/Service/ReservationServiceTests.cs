using Xunit;
using Moq;
using MS.Application.Services;
using MS.Infrastructure.Repositories.UnitOfWork;
using MS.Application.DTOs.Reservation;
using MS.Data.Entities;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MS.Application.Tests.Services
{
    public class ReservationServiceTests
    {
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;
        private readonly ReservationService _reservationService;
        private readonly Mock<UserManager<ApplicationUser>> _userManagerMock;

        public ReservationServiceTests()
        {
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            var userStoreMock = new Mock<IUserStore<ApplicationUser>>();
            _userManagerMock = new Mock<UserManager<ApplicationUser>>(userStoreMock.Object, null, null, null, null, null, null, null, null);
            _reservationService = new ReservationService(_unitOfWorkMock.Object, _userManagerMock.Object);
        }

        [Fact]
        public async Task PlaceReservationAsync_ValidModel_ReturnsCreatedResponse()
        {
            // Arrange
            var model = new PlaceReservationDto { UserID = "1", PlacePriceId = 1 };
            var reservation = new Reservation { UserID = model.UserID, PlacePriceId = model.PlacePriceId };

            _unitOfWorkMock.Setup(u => u.Reservations.AddAsync(It.IsAny<Reservation>())).ReturnsAsync(reservation);

            // Act
            var response = await _reservationService.PlaceReservationAsync(model);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("Entity created", response.Message);
            Assert.NotNull(response.Data);
        }

        [Fact]
        public async Task DeleteReservationAsync_ValidId_ReturnsDeletedResponse()
        {
            // Arrange
            var reservation = new Reservation { ID = 1, UserID = "1", PlacePriceId = 1 };

            _unitOfWorkMock.Setup(u => u.Reservations.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(reservation);
            _unitOfWorkMock.Setup(u => u.Reservations.DeleteAsync(It.IsAny<Reservation>())).Returns(Task.CompletedTask);

            // Act
            var response = await _reservationService.DeleteReservationAsync(reservation.ID);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("Deleted Successfully", response.Message);
        }

        [Fact]
        public async Task GetReservationAsync_ValidId_ReturnsReservation()
        {
            // Arrange
            var reservation = new Reservation { ID = 1, UserID = "1", PlacePriceId = 1 };

            _unitOfWorkMock.Setup(u => u.Reservations.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(reservation);

            // Act
            var response = await _reservationService.GetReservationAsync(reservation.ID);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("succeeded process", response.Message);
            Assert.NotNull(response.Data);
        }

        [Fact]
        public async Task UpdateReservationAsync_ValidModel_ReturnsUpdatedResponse()
        {
            // Arrange
            var model = new UpdateReservationDto { ID = 1, UserID = "1", PlacePriceId = 1 };
            var reservation = new Reservation { ID = model.ID, UserID = model.UserID, PlacePriceId = model.PlacePriceId };

            _unitOfWorkMock.Setup(u => u.Reservations.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(reservation);
            _unitOfWorkMock.Setup(u => u.Reservations.UpdateAsync(It.IsAny<Reservation>())).Returns(Task.CompletedTask);

            // Act
            var response = await _reservationService.UpdateReservationAsync(model);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("Updated Successfully", response.Message);
            Assert.NotNull(response.Data);
        }
        
        
        
    }
}