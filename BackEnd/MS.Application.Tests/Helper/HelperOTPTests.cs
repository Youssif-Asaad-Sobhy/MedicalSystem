using Xunit;
using MS.Application.Helpers.OTP;

namespace MS.Application.Tests
{
    public class OTPHelperTests
    {
        [Fact]
        public void GenerateOTP_IsNotNull()
        {
            // act
            string otp = OTPHelper.GenerateOTP();

            // assert
            Assert.NotNull(otp);
        }
        [Fact]
        public void GenerateOTP_IsSixDigits()
        {
            // act
            string otp = OTPHelper.GenerateOTP();

            // assert
            Assert.True(otp.Length == 6);
        }
        [Fact]
        public void GenerateOTP_IsDifferentEachTime()
        {
            // act
            string otp1 = OTPHelper.GenerateOTP();
            string otp2 = OTPHelper.GenerateOTP();

            // assert
            Assert.NotEqual(otp1, otp2);
        }
    }
}