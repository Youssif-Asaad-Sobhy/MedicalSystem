using Xunit;
using Moq;
using MS.Application.DTOs.ReportMedicine;
using MS.Data.Entities;
using MS.Infrastructure.Repositories.UnitOfWork;
using System.Threading.Tasks;
using MS.Application.Services;

namespace MS.Application.Tests.Services
{
    public class ReportMedicineServiceTests
    {
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;
        private readonly ReportMedicineService _reportMedicineService;

        public ReportMedicineServiceTests()
        {
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _reportMedicineService = new ReportMedicineService(_unitOfWorkMock.Object);
        }

        [Fact]
        public async Task CreateReportMedicineAsync_ShouldReturnBadRequest_WhenModelIsNull()
        {
            var result = await _reportMedicineService.CreateReportMedicineAsync(null);
            Assert.Equal("ReportMedicine model not found.", result.Message);
        }

        [Fact]
        public async Task DeleteReportMedicineAsync_ShouldReturnBadRequest_WhenReportMedicineDoesNotExist()
        {
            _unitOfWorkMock.Setup(u => u.ReportMedicines.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((ReportMedicine)null);

            var result = await _reportMedicineService.DeleteReportMedicineAsync(1);
            Assert.Equal("ReportMedicine with ID 1 not found.", result.Message);
        }

        [Fact]
        public async Task GetReportMedicineAsync_ShouldReturnBadRequest_WhenReportMedicineDoesNotExist()
        {
            _unitOfWorkMock.Setup(u => u.ReportMedicines.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((ReportMedicine)null);

            var result = await _reportMedicineService.GetReportMedicineAsync(1);
            Assert.Equal("ReportMedicine with ID 1 not found.", result.Message);
        }

        [Fact]
        public async Task UpdateReportMedicineAsync_ShouldReturnBadRequest_WhenReportMedicineDoesNotExist()
        {
            _unitOfWorkMock.Setup(u => u.ReportMedicines.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((ReportMedicine)null);

            var result = await _reportMedicineService.UpdateReportMedicineAsync(new UpdateReportMedicineDto { ID = 1 });
            Assert.Equal("ReportMedicine with ID 1 not found.", result.Message);
        }

        [Fact]
        public async Task CreateReportMedicineAsync_ShouldReturnCreated_WhenModelIsValid()
        {
            var model = new CreateReportMedicineDto { ReportID = 1, MedicineTypeID = 1 };
            _unitOfWorkMock.Setup(u => u.ReportMedicines.AddAsync(It.IsAny<ReportMedicine>())).Returns(Task.FromResult(new ReportMedicine()));

            var result = await _reportMedicineService.CreateReportMedicineAsync(model);

            Assert.Equal("Entity created", result.Message);
        }

        [Fact]
        public async Task DeleteReportMedicineAsync_ShouldReturnDeleted_WhenReportMedicineExists()
        {
            var reportMedicine = new ReportMedicine { ID = 1, ReportID = 1, MedicineTypeID = 1 };
            _unitOfWorkMock.Setup(u => u.ReportMedicines.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(reportMedicine);
            _unitOfWorkMock.Setup(u => u.ReportMedicines.DeleteAsync(It.IsAny<ReportMedicine>())).Returns(Task.CompletedTask);

            var result = await _reportMedicineService.DeleteReportMedicineAsync(1);

            Assert.Equal("Deleted Successfully", result.Message);
        }

        [Fact]
        public async Task GetReportMedicineAsync_ShouldReturnSuccess_WhenReportMedicineExists()
        {
            var reportMedicine = new ReportMedicine { ID = 1, ReportID = 1, MedicineTypeID = 1 };
            _unitOfWorkMock.Setup(u => u.ReportMedicines.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(reportMedicine);

            var result = await _reportMedicineService.GetReportMedicineAsync(1);

            Assert.Equal("succeeded process", result.Message);
            Assert.Equal(reportMedicine, result.Data);
        }

        [Fact]
        public async Task UpdateReportMedicineAsync_ShouldReturnSuccess_WhenReportMedicineExistsAndModelIsValid()
        {
            var reportMedicine = new ReportMedicine { ID = 1, ReportID = 1, MedicineTypeID = 1 };
            var model = new UpdateReportMedicineDto { ID = 1, ReportID = 2, MedicineTypeID = 2 };
            _unitOfWorkMock.Setup(u => u.ReportMedicines.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(reportMedicine);

            var result = await _reportMedicineService.UpdateReportMedicineAsync(model);

            Assert.Equal("Updated Successfully", result.Message);
            Assert.Equal(model.ReportID, result.Data.ReportID);
            Assert.Equal(model.MedicineTypeID, result.Data.MedicineTypeID);
        }
    }
}