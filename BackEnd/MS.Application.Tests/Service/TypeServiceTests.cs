using MS.Application.DTOs.Document;
using MS.Application.Helpers.Response;
using MS.Application.Interfaces;
using MS.Data.Entities;
using MS.Infrastructure.Repositories.UnitOfWork;
using MS.Application.DTOs.MedicineType;
using MS.Application.DTOs.Types;
using System;
using System.Threading.Tasks;
using Xunit;
using Moq;
using MS.Application.Services;

namespace MS.Application.Tests.Services
{
    public class TypeServicesTests
    {
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;
        private readonly TypeServices _typeServices;

        public TypeServicesTests()
        {
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _typeServices = new TypeServices(_unitOfWorkMock.Object);
        }

        [Fact]
        public async Task CreateTypeAsync_ShouldReturnBadRequest_WhenModelIsNull()
        {
            var result = await _typeServices.CreateTypeAsync(null);
            Assert.Equal("Type model not found.", result.Message);
        }

        [Fact]
        public async Task DeleteTypeAsync_ShouldReturnBadRequest_WhenTypeDoesNotExist()
        {
            _unitOfWorkMock.Setup(u => u.Types.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((Types)null);

            var result = await _typeServices.DeleteTypeAsync(1);
            Assert.Equal("Type model is null or not found", result.Message);
        }

        [Fact]
        public async Task GetTypeAsync_ShouldReturnBadRequest_WhenTypeDoesNotExist()
        {
            _unitOfWorkMock.Setup(u => u.Types.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((Types)null);

            var result = await _typeServices.GetTypeAsync(1);
            Assert.Equal("Type model is null or not found", result.Message);
        }

        [Fact]
        public async Task UpdateTypeAsync_ShouldReturnBadRequest_WhenTypeDoesNotExist()
        {
            _unitOfWorkMock.Setup(u => u.Types.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((Types)null);

            var result = await _typeServices.UpdateTypeAsync(new UpdateTypeDto { ID = 1 });
            Assert.Equal("Type model is null or not found", result.Message);
        }
        [Fact]
        public async Task CreateTypeAsync_ShouldReturnCreated_WhenModelIsValid()
        {
            var model = new CreateTypeDto { Name = "Test" };
            _unitOfWorkMock.Setup(u => u.Types.AddAsync(It.IsAny<Types>())).Returns(Task.FromResult(new Types()));
            var result = await _typeServices.CreateTypeAsync(model);

            Assert.Equal("Entity created", result.Message);
        }

        [Fact]
        public async Task DeleteTypeAsync_ShouldReturnDeleted_WhenTypeExists()
        {
            var type = new Types { ID = 1, Name = "Test" };
            _unitOfWorkMock.Setup(u => u.Types.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(type);
            _unitOfWorkMock.Setup(u => u.Types.DeleteAsync(It.IsAny<Types>())).Returns(Task.CompletedTask);

            var result = await _typeServices.DeleteTypeAsync(1);

            Assert.Equal("Deleted Successfully", result.Message);
        }

        [Fact]
        public async Task GetTypeAsync_ShouldReturnSuccess_WhenTypeExists()
        {
            var type = new Types { ID = 1, Name = "Test" };
            _unitOfWorkMock.Setup(u => u.Types.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(type);

            var result = await _typeServices.GetTypeAsync(1);

            Assert.Equal("succeeded process", result.Message);
            Assert.Equal(type, result.Data);
        }

        [Fact]
        public async Task UpdateTypeAsync_ShouldReturnSuccess_WhenTypeExistsAndModelIsValid()
        {
            var type = new Types { ID = 1, Name = "Test" };
            var model = new UpdateTypeDto { ID = 1, Name = "Updated" };
            _unitOfWorkMock.Setup(u => u.Types.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(type);

            var result = await _typeServices.UpdateTypeAsync(model);

            Assert.Equal("succeeded process", result.Message);
            Assert.Equal(model.Name, result.Data.Name);
        }
    }
}