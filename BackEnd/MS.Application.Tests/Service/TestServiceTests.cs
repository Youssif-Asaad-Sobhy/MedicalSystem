using Xunit;
using Moq;
using MS.Application.DTOs.Test;
using MS.Data.Entities;
using MS.Infrastructure.Repositories.UnitOfWork;
using System.Threading.Tasks;
using MS.Application.Services;

namespace MS.Application.Tests.Services
{
    public class TestServiceTests
    {
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;
        private readonly TestService _testService;

        public TestServiceTests()
        {
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _testService = new TestService(_unitOfWorkMock.Object);
        }

        [Fact]
        public async Task CreateTestAsync_ShouldReturnBadRequest_WhenModelIsNull()
        {
            var result = await _testService.CreateTestAsync(null);
            Assert.Equal("Test model not found.", result.Message);
        }

        [Fact]
        public async Task DeleteTestAsync_ShouldReturnBadRequest_WhenTestDoesNotExist()
        {
            _unitOfWorkMock.Setup(u => u.Tests.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((Test)null);

            var result = await _testService.DeleteTestAsync(1);
            Assert.Equal("Test with ID 1 not found.", result.Message);
        }

        [Fact]
        public async Task GetTestAsync_ShouldReturnBadRequest_WhenTestDoesNotExist()
        {
            _unitOfWorkMock.Setup(u => u.Tests.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((Test)null);

            var result = await _testService.GetTestAsync(1);
            Assert.Equal("Test with ID 1 not found.", result.Message);
        }

        [Fact]
        public async Task UpdateTestAsync_ShouldReturnBadRequest_WhenTestDoesNotExist()
        {
            _unitOfWorkMock.Setup(u => u.Tests.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((Test)null);

            var result = await _testService.UpdateTestAsync(new UpdateTestDto { ID = 1 });
            Assert.Equal("Test with ID 1 not found.", result.Message);
        }

        [Fact]
        public async Task CreateTestAsync_ShouldReturnCreated_WhenModelIsValid()
        {
            var model = new CreateTestDto { Name = "Test" };
            _unitOfWorkMock.Setup(u => u.Tests.AddAsync(It.IsAny<Test>())).Returns(Task.FromResult(new Test()));

            var result = await _testService.CreateTestAsync(model);

            Assert.Equal("Entity created", result.Message);
        }

        [Fact]
        public async Task DeleteTestAsync_ShouldReturnDeleted_WhenTestExists()
        {
            var test = new Test { ID = 1, Name = "Test" };
            _unitOfWorkMock.Setup(u => u.Tests.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(test);
            _unitOfWorkMock.Setup(u => u.Tests.DeleteAsync(It.IsAny<Test>())).Returns(Task.CompletedTask);

            var result = await _testService.DeleteTestAsync(1);

            Assert.Equal("Deleted Successfully", result.Message);
        }

        [Fact]
        public async Task GetTestAsync_ShouldReturnSuccess_WhenTestExists()
        {
            var test = new Test { ID = 1, Name = "Test" };
            _unitOfWorkMock.Setup(u => u.Tests.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(test);

            var result = await _testService.GetTestAsync(1);

            Assert.Equal("succeeded process", result.Message);
            Assert.Equal(test, result.Data);
        }

        [Fact]
        public async Task UpdateTestAsync_ShouldReturnSuccess_WhenTestExistsAndModelIsValid()
        {
            var test = new Test { ID = 1, Name = "Test" };
            var model = new UpdateTestDto { ID = 1, Name = "Updated" };
            _unitOfWorkMock.Setup(u => u.Tests.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(test);

            var result = await _testService.UpdateTestAsync(model);

            Assert.Equal("Updated Successfully", result.Message);
            Assert.Equal(model.Name, result.Data.Name);
        }
    }
}