using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Moq;
using MS.Application.Helpers.UserManagerExtensions;
using System.Security.Claims;
using Xunit;

namespace MS.Application.Helpers.UserManagerExtensions
{
    public class UserManagerExtensionsTests
    {
        [Fact]
        public void GetCurrentUserId_ReturnsUserId()
        {
            // Arrange
            var userManagerMock = new Mock<UserManager<IdentityUser>>(Mock.Of<IUserStore<IdentityUser>>(), null, null, null, null, null, null, null, null);
            var httpContextAccessorMock = new Mock<IHttpContextAccessor>();
            var expectedUserId = "test-user-id";

            var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new Claim[]
            {
            new Claim("uid", expectedUserId),
            }));

            httpContextAccessorMock.Setup(x => x.HttpContext.User)
                .Returns(claimsPrincipal);

            // Act
            var actualUserId = userManagerMock.Object.GetCurrentUserId(httpContextAccessorMock.Object);

            // Assert
            Assert.Equal(expectedUserId, actualUserId);
        }

        [Fact]
        public void GetCurrentUserId_ThrowsUnauthorizedAccessException_WhenUserIdIsNull()
        {
            // Arrange
            var userManagerMock = new Mock<UserManager<IdentityUser>>(Mock.Of<IUserStore<IdentityUser>>(), null, null, null, null, null, null, null, null);
            var httpContextAccessorMock = new Mock<IHttpContextAccessor>();

            var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new Claim[] { }));

            httpContextAccessorMock.Setup(x => x.HttpContext.User)
                .Returns(claimsPrincipal);

            // Act & Assert
            Assert.Throws<UnauthorizedAccessException>(() => userManagerMock.Object.GetCurrentUserId(httpContextAccessorMock.Object));
        }
    }
}