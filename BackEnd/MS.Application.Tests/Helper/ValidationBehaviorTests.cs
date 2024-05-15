using Xunit;
using Moq;
using MS.Application.Helpers.ValidationHelper;
using FluentValidation;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation.Results;

namespace MS.Application.Helpers.ValidationHelper
{
    public class ValidationBehaviorTests
    {
        private readonly Mock<IValidator<TestRequest>> _validatorMock;
        private readonly ValidationBehavior<TestRequest, TestResponse> _validationBehavior;

        public ValidationBehaviorTests()
        {
            _validatorMock = new Mock<IValidator<TestRequest>>();
            _validationBehavior = new ValidationBehavior<TestRequest, TestResponse>(new List<IValidator<TestRequest>> { _validatorMock.Object });
        }
        
        [Fact]
        public async Task Handle_WhenCalledWithValidRequest_DoesNotThrowException()
        {
            // Arrange
            var request = new TestRequest();
            var context = new ValidationContext<TestRequest>(request);
            var validationResult = new ValidationResult(new List<ValidationFailure>());

            _validatorMock.Setup(v => v.ValidateAsync(context, It.IsAny<CancellationToken>())).ReturnsAsync(validationResult);

            // Act
            var ex = await Record.ExceptionAsync(() => _validationBehavior.Handle(request, () => Task.FromResult(new TestResponse()), default));

            // Assert
            Assert.Null(ex);
        }

        [Fact]
        public async Task Handle_WhenCalledWithValidRequest_ReturnsResponseFromNextDelegate()
        {
            // Arrange
            var request = new TestRequest();
            var context = new ValidationContext<TestRequest>(request);
            var validationResult = new ValidationResult(new List<ValidationFailure>());

            _validatorMock.Setup(v => v.ValidateAsync(context, It.IsAny<CancellationToken>())).ReturnsAsync(validationResult);

            // Act
            var response = await _validationBehavior.Handle(request, () => Task.FromResult(new TestResponse()), default);

            // Assert
            Assert.NotNull(response);
        }
    }
    
    public class TestRequest : IRequest<TestResponse>
    {
    }

    public class TestResponse
    {
    }
}