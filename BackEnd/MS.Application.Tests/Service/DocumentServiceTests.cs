using System.Text;
using Xunit;
using Moq;
using MS.Application.Services;
using MS.Infrastructure.Repositories.UnitOfWork;
using MS.Application.DTOs.Document;
using MS.Data.Entities;
using System.Threading.Tasks;

namespace MS.Application.Tests.Services
{
    public class DocumentServiceTests
    {
        private readonly DocumentService _documentService;
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;

        public DocumentServiceTests()
        {
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _documentService = new DocumentService(_unitOfWorkMock.Object);
        }

        [Fact]
        public async Task CreateDocAsync_ValidModel_ReturnsCreatedResponse()
        {
            // Arrange
            var content = Encoding.UTF8.GetBytes("Test Content");
            
            var model = new CreateDoctDto { Content = content, ReportID = 1 };
            var document = new Document { Content = model.Content, ReportID = model.ReportID };

            _unitOfWorkMock.Setup(u => u.Documents.AddAsync(It.IsAny<Document>())).ReturnsAsync(document);

            // Act
            var response = await _documentService.CreateDocAsync(model);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("Entity created", response.Message);
            Assert.NotNull(response.Data);
        }

        [Fact]
        public async Task DeleteDocAsync_ValidId_ReturnsDeletedResponse()
        {
            // Arrange
            var id = 1;
            var document = new Document { ID = id };

            _unitOfWorkMock.Setup(u => u.Documents.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(document);
            _unitOfWorkMock.Setup(u => u.Documents.DeleteAsync(It.IsAny<Document>())).Returns(Task.CompletedTask);

            // Act
            var response = await _documentService.DeleteDocAsync(id);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("Deleted Successfully", response.Message);
        }

        [Fact]
        public async Task GetDocByIDAsync_ValidId_ReturnsDocument()
        {
            // Arrange
            var id = 1;
            var content = Encoding.UTF8.GetBytes("Test Content");
            var document = new Document { ID = id, Content = content, ReportID = 1 };

            _unitOfWorkMock.Setup(u => u.Documents.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(document);

            // Act
            var response = await _documentService.GetDocByIDAsync(id);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("succeeded process", response.Message);
            Assert.NotNull(response.Data);
        }
        [Fact]
        public async Task UpdateDocAsync_ValidModel_ReturnsUpdatedResponse()
        {
            // Arrange
            var content = Encoding.UTF8.GetBytes("Updated Content");
            var model = new UpdateDoctDto { ID = 1, Content = content, ReportID = 1 };
            var document = new Document { ID = model.ID, Content = model.Content, ReportID = model.ReportID };

            _unitOfWorkMock.Setup(u => u.Documents.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(document);
            _unitOfWorkMock.Setup(u => u.Documents.UpdateAsync(It.IsAny<Document>())).Returns(Task.CompletedTask);

            // Act
            var response = await _documentService.UpdateDocAsync(model);

            // Assert
            Assert.True(response.Succeeded);
            Assert.Equal("succeeded process", response.Message);
            Assert.NotNull(response.Data);
        } 
    }
}