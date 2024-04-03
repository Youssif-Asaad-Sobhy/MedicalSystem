using Xunit;
using MS.Application.Helpers.Pagination;
using MS.Application.Helpers.Response;
using System.Net;

namespace MS.Application.Tests.Helpers
{
    public class ResponseHandlerTests
    {
        [Fact]
        public void Success_ReturnsCorrectPaginatedResult()
        {
            // Arrange
            var data = new List<int> { 1, 2, 3 };
            var pageFilter = new PageFilter { PageNumber = 1, PageSize = 10 };
            int totalRecords = 3;

            // Act
            var result = ResponseHandler.Success(data, pageFilter, totalRecords);

            // Assert
            Assert.True(result.Succeeded);
            Assert.Equal(data, result.Data);
        }

        [Fact]
        public void Updated_ReturnsCorrectResponse()
        {
            // Arrange
            var entity = "Test Entity";

            // Act
            var result = ResponseHandler.Updated(entity);

            // Assert
            Assert.True(result.Succeeded);
            Assert.Equal(HttpStatusCode.OK, result.StatusCode);
            Assert.Equal("Updated Successfully", result.Message);
            Assert.Equal(entity, result.Data);
        }

        [Fact]
        public void Deleted_ReturnsCorrectResponse()
        {
            // Act
            var result = ResponseHandler.Deleted<string>();

            // Assert
            Assert.True(result.Succeeded);
            Assert.Equal(HttpStatusCode.OK, result.StatusCode);
            Assert.Equal("Deleted Successfully", result.Message);
        }

        [Fact]
        public void Success_ReturnsCorrectResponseWithMessage()
        {
            // Arrange
            var message = "Test Message";

            // Act
            var result = ResponseHandler.Success<string>(message);

            // Assert
            Assert.True(result.Succeeded);
            Assert.Equal(HttpStatusCode.OK, result.StatusCode);
            Assert.Equal(message, result.Message);
        }

        [Fact]
        public void Success_ReturnsCorrectResponseWithEntityAndMeta()
        {
            // Arrange
            var entity = "Test Entity";
            var meta = new { key = "value" };

            // Act
            var result = ResponseHandler.Success(entity, meta);

            // Assert
            Assert.True(result.Succeeded);
            Assert.Equal(HttpStatusCode.OK, result.StatusCode);
            Assert.Equal("succeeded process", result.Message);
            Assert.Equal(entity, result.Data);
            Assert.Equal(meta, result.Meta);
        }

        [Fact]
        public void Unauthorized_ReturnsCorrectResponse()
        {
            // Act
            var result = ResponseHandler.Unauthorized<string>();

            // Assert
            Assert.True(result.Succeeded);
            Assert.Equal(HttpStatusCode.Unauthorized, result.StatusCode);
            Assert.Equal("UnAuthorized", result.Message);
        }

        [Fact]
        public void BadRequest_ReturnsCorrectResponse()
        {
            // Arrange
            var message = "Test Message";

            // Act
            var result = ResponseHandler.BadRequest<string>(message);

            // Assert
            Assert.False(result.Succeeded);
            Assert.Equal(HttpStatusCode.BadRequest, result.StatusCode);
            Assert.Equal(message, result.Message);
        }

        [Fact]
        public void NotFound_ReturnsCorrectResponse()
        {
            // Arrange
            var message = "Test Message";

            // Act
            var result = ResponseHandler.NotFound<string>(message);

            // Assert
            Assert.False(result.Succeeded);
            Assert.Equal(HttpStatusCode.NotFound, result.StatusCode);
            Assert.Equal(message, result.Message);
        }

        [Fact]
        public void Created_ReturnsCorrectResponse()
        {
            // Arrange
            var entity = "Test Entity";
            var meta = new { key = "value" };

            // Act
            var result = ResponseHandler.Created(entity, meta);

            // Assert
            Assert.True(result.Succeeded);
            Assert.Equal(HttpStatusCode.Created, result.StatusCode);
            Assert.Equal("Entity created", result.Message);
            Assert.Equal(entity, result.Data);
            Assert.Equal(meta, result.Meta);
        }
    }
}