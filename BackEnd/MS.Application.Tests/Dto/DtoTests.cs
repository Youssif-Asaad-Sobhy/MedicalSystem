using System;
using Xunit;
using MS.Application.DTOs.Reservation;

namespace MS.Application.Tests.Dto
{
    public class DtoTests
    {
        [Fact]
        public void UserBasicDataDto_NationalIDToAge_ReturnTheAge()
        {
            // arrange
            var userBasicDataDto = new UserBasicDataDto { NID = "30209252700251" };
            // act

            int actualAge = userBasicDataDto.Age;
            int expectedAge = 21;
            // assert
            Assert.Equal(expectedAge, actualAge);
        }
        [Fact]
        public void UserBasicDataDto_NationalIDIsNull_ReturnNullException()
        {
            // arrange
            var userBasicDataDto = new UserBasicDataDto { NID = null };
            // act
            // assert
            Assert.Throws<ArgumentNullException>(() => userBasicDataDto.Age);


        }

        [Fact]
        public void UserBasicDataDto_NIDIsNotCorrectFormat_ReturnsZero()
        {
            // arrange
            var userBasicDataDto = new UserBasicDataDto { NID = "12345" };
            var userBasicDataDto2 = new UserBasicDataDto { NID = "12345678901234567890" };

            // act
            int age = userBasicDataDto.Age;
            int age2 = userBasicDataDto2.Age;

            // assert
            Assert.Equal(0, age);
            Assert.Equal(0, age2);
        }

    }
}