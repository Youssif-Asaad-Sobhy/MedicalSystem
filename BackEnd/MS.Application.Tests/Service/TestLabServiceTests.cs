using Xunit;
using Moq;
using MS.Application.DTOs.TestLab;
using MS.Data.Entities;
using MS.Infrastructure.Repositories.UnitOfWork;
using System.Threading.Tasks;
using MS.Application.Services;

namespace MS.Application.Tests.Services
{
    public class TestLabServiceTests
    {
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;
        private readonly TestLabService _testLabService;

        public TestLabServiceTests()
        {
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _testLabService = new TestLabService(_unitOfWorkMock.Object);
        }

        [Fact]
        public async Task CreateTestLabAsync_ShouldReturnBadRequest_WhenModelIsNull()
        {
            var result = await _testLabService.CreateTestLabAsync(null);
            Assert.Equal("Test model not found.", result.Message);
        }

        [Fact]
        public async Task DeleteTestLabAsync_ShouldReturnBadRequest_WhenTestLabDoesNotExist()
        {
            _unitOfWorkMock.Setup(u => u.TestLabs.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((TestLab)null);

            var result = await _testLabService.DeleteTestLabAsync(1);
            Assert.Equal("Test with ID 1 not found.", result.Message);
        }

        [Fact]
        public async Task GetTestLabAsync_ShouldReturnBadRequest_WhenTestLabDoesNotExist()
        {
            _unitOfWorkMock.Setup(u => u.TestLabs.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((TestLab)null);

            var result = await _testLabService.GetTestLabAsync(1);
            Assert.Equal("TestLab with ID 1 not found.", result.Message);
        }

        [Fact]
        public async Task UpdateTestLabAsync_ShouldReturnBadRequest_WhenTestLabDoesNotExist()
        {
            _unitOfWorkMock.Setup(u => u.TestLabs.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((TestLab)null);

            var result = await _testLabService.UpdateTestLabAsync(new UpdateTestLabDto { ID = 1 });
            Assert.Equal("TestLab with ID 1 not found.", result.Message);
        }

        [Fact]
        public async Task CreateTestLabAsync_ShouldReturnCreated_WhenModelIsValid()
        {
            var model = new CreateTestLabDto { TestLabID = 1, LabID = 1, Price = 100, Description = "Test" };
            _unitOfWorkMock.Setup(u => u.TestLabs.AddAsync(It.IsAny<TestLab>())).Returns(Task.FromResult(new TestLab()));

            var result = await _testLabService.CreateTestLabAsync(model);

            Assert.Equal("Entity created", result.Message);
        }

        [Fact]
        public async Task DeleteTestLabAsync_ShouldReturnDeleted_WhenTestLabExists()
        {
            var testLab = new TestLab { ID = 1, TestLabID = 1, LabID = 1, Price = 100, Description = "Test" };
            _unitOfWorkMock.Setup(u => u.TestLabs.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(testLab);
            _unitOfWorkMock.Setup(u => u.TestLabs.DeleteAsync(It.IsAny<TestLab>())).Returns(Task.CompletedTask);

            var result = await _testLabService.DeleteTestLabAsync(1);

            Assert.Equal("Deleted Successfully", result.Message);
        }

        [Fact]
        public async Task GetTestLabAsync_ShouldReturnSuccess_WhenTestLabExists()
        {
            var testLab = new TestLab { ID = 1, TestLabID = 1, LabID = 1, Price = 100, Description = "Test" };
            _unitOfWorkMock.Setup(u => u.TestLabs.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(testLab);

            var result = await _testLabService.GetTestLabAsync(1);

            Assert.Equal("succeeded process", result.Message);
            Assert.Equal(testLab, result.Data);
        }

        [Fact]
        public async Task UpdateTestLabAsync_ShouldReturnSuccess_WhenTestLabExistsAndModelIsValid()
        {
            var testLab = new TestLab { ID = 1, TestLabID = 1, LabID = 1, Price = 100, Description = "Test" };
            var model = new UpdateTestLabDto { ID = 1, TestLabID = 2, LabID = 2, Price = 200, Description = "Updated" };
            _unitOfWorkMock.Setup(u => u.TestLabs.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(testLab);

            var result = await _testLabService.UpdateTestLabAsync(model);

            Assert.Equal("Updated Successfully", result.Message);
            Assert.Equal(model.Description, result.Data.Description);
        }
    }
}