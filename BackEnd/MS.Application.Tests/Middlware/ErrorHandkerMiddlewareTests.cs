using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace MS.Application.Middlewares.Tests
{
    public class ErrorHandlerMiddlewareTests
    {
        private readonly Mock<RequestDelegate> _mockRequestDelegate;
        private readonly ErrorHandlerMiddleware _middleware;

        public ErrorHandlerMiddlewareTests()
        {
            _mockRequestDelegate = new Mock<RequestDelegate>();
            _middleware = new ErrorHandlerMiddleware(_mockRequestDelegate.Object);
        }

        [Fact]
        public async Task Invoke_ShouldHandle_UnauthorizedAccessException()
        {
            // Arrange
            _mockRequestDelegate.Setup(rd => rd(It.IsAny<HttpContext>())).Throws(new UnauthorizedAccessException());

            var context = new DefaultHttpContext();
            context.Response.Body = new MemoryStream();

            // Act
            await _middleware.Invoke(context);

            // Assert
            Assert.Equal((int)HttpStatusCode.Unauthorized, context.Response.StatusCode);
        }

        [Fact]
        public async Task Invoke_ShouldHandle_ValidationException()
        {
            // Arrange
            _mockRequestDelegate.Setup(rd => rd(It.IsAny<HttpContext>())).Throws(new ValidationException("Validation error occurred"));

            var context = new DefaultHttpContext();
            context.Response.Body = new MemoryStream();

            // Act
            await _middleware.Invoke(context);

            // Assert
            Assert.Equal((int)HttpStatusCode.UnprocessableEntity, context.Response.StatusCode);
        }

        [Fact]
        public async Task Invoke_ShouldHandle_KeyNotFoundException()
        {
            // Arrange
            _mockRequestDelegate.Setup(rd => rd(It.IsAny<HttpContext>())).Throws(new KeyNotFoundException());

            var context = new DefaultHttpContext();
            context.Response.Body = new MemoryStream();

            // Act
            await _middleware.Invoke(context);

            // Assert
            Assert.Equal((int)HttpStatusCode.NotFound, context.Response.StatusCode);
        }

        [Fact]
        public async Task Invoke_ShouldHandle_DbUpdateException()
        {
            // Arrange
            _mockRequestDelegate.Setup(rd => rd(It.IsAny<HttpContext>())).Throws(new DbUpdateException());

            var context = new DefaultHttpContext();
            context.Response.Body = new MemoryStream();

            // Act
            await _middleware.Invoke(context);

            // Assert
            Assert.Equal((int)HttpStatusCode.BadRequest, context.Response.StatusCode);
        }
        // this test is not correct, it should be fixed open file errorhandlerMiddleWare.cs line 63:76
        [Fact]
        public async Task Invoke_ShouldHandle_ApiException()
        {
            // Arrange
            _mockRequestDelegate.Setup(rd => rd(It.IsAny<HttpContext>())).Throws(new Exception("ApiException"));

            var context = new DefaultHttpContext();
            context.Response.Body = new MemoryStream();

            // Act
            await _middleware.Invoke(context);

            // Assert
            Assert.Equal((int)HttpStatusCode.BadRequest, context.Response.StatusCode);
        }

        [Fact]
        public async Task Invoke_ShouldHandle_OtherException()
        {
            // Arrange
            _mockRequestDelegate.Setup(rd => rd(It.IsAny<HttpContext>())).Throws(new Exception());

            var context = new DefaultHttpContext();
            context.Response.Body = new MemoryStream();

            // Act
            await _middleware.Invoke(context);

            // Assert
            Assert.Equal((int)HttpStatusCode.InternalServerError, context.Response.StatusCode);
        }


    }
}