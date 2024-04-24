using FluentValidation;
using MediatR;
using Moq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace MS.Application.Helpers.ValidationHelper
{
    public class ValidationBehaviorTests
    {
        [Fact]
        public async Task Handle_WhenCalledWithInvalidRequest_ThrowsValidationException()
        {
        }

        [Fact]
        public async Task Handle_WhenCalledWithValidRequest_ReturnsResponseFromNextDelegate()
        {
        }
    }
}