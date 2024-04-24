using Xunit;
using Moq;
using MS.Application.DTOs.Report;
using MS.Data.Entities;
using MS.Infrastructure.Repositories.UnitOfWork;
using System.Threading.Tasks;
using MS.Application.Services;

namespace MS.Application.Tests.Services
{
    public class ReportServiceTests
    {
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;
        private readonly ReportService _reportService;

        public ReportServiceTests()
        {
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _reportService = new ReportService(_unitOfWorkMock.Object);
        }

        [Fact]
        public async Task CreateReportAsync_ShouldReturnBadRequest_WhenModelIsNull()
        {
            var result = await _reportService.CreateReportAsync(null);
            Assert.Equal("Report model not found.", result.Message);
        }

        [Fact]
        public async Task DeleteReportAsync_ShouldReturnBadRequest_WhenReportDoesNotExist()
        {
            _unitOfWorkMock.Setup(u => u.Reports.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((Report)null);

            var result = await _reportService.DeleteReportAsync(1);
            Assert.Equal("Report with ID 1 not found.", result.Message);
        }

        [Fact]
        public async Task GetReportAsync_ShouldReturnBadRequest_WhenReportDoesNotExist()
        {
            _unitOfWorkMock.Setup(u => u.Reports.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((Report)null);

            var result = await _reportService.GetReportAsync(1);
            Assert.Equal("Report with ID 1 not found.", result.Message);
        }

        [Fact]
        public async Task UpdateReportAsync_ShouldReturnBadRequest_WhenReportDoesNotExist()
        {
            _unitOfWorkMock.Setup(u => u.Reports.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((Report)null);

            var result = await _reportService.UpdateReportAsync(new UpdateReportDto { ID = 1 });
            Assert.Equal("Report with ID 1 not found.", result.Message);
        }

        [Fact]
        public async Task CreateReportAsync_ShouldReturnCreated_WhenModelIsValid()
        {
            var model = new CreateReportDto { Description = "Test", UserID = "Test", DoctorID = "Test" };
            _unitOfWorkMock.Setup(u => u.Reports.AddAsync(It.IsAny<Report>())).Returns(Task.FromResult(new Report()));

            var result = await _reportService.CreateReportAsync(model);

            Assert.Equal("Entity created", result.Message);
        }

        [Fact]
        public async Task DeleteReportAsync_ShouldReturnDeleted_WhenReportExists()
        {
            var report = new Report { ID = 1, Description = "Test", UserID = "Test", DoctorID = "Test" };
            _unitOfWorkMock.Setup(u => u.Reports.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(report);
            _unitOfWorkMock.Setup(u => u.Reports.DeleteAsync(It.IsAny<Report>())).Returns(Task.CompletedTask);

            var result = await _reportService.DeleteReportAsync(1);

            Assert.Equal("Deleted Successfully", result.Message);
        }

        [Fact]
        public async Task GetReportAsync_ShouldReturnSuccess_WhenReportExists()
        {
            var report = new Report { ID = 1, Description = "Test", UserID = "Test", DoctorID = "Test" };
            _unitOfWorkMock.Setup(u => u.Reports.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(report);

            var result = await _reportService.GetReportAsync(1);

            Assert.Equal("succeeded process", result.Message);
            Assert.Equal(report, result.Data);
        }

        [Fact]
        public async Task UpdateReportAsync_ShouldReturnSuccess_WhenReportExistsAndModelIsValid()
        {
            var report = new Report { ID = 1, Description = "Test", UserID = "Test", DoctorID = "Test" };
            var model = new UpdateReportDto { ID = 1, Description = "Updated", UserID = "Updated", DoctorID = "Updated" };
            _unitOfWorkMock.Setup(u => u.Reports.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(report);

            var result = await _reportService.UpdateReportAsync(model);

            Assert.Equal("Updated Successfully", result.Message);
            Assert.Equal(model.Description, result.Data.Description);
        }
    }
}