using Moq;
using System;
using Xunit;

namespace DateApp.Test
{
    public class SeasonFinderTest
    {
        [Fact]
        public void TestSummer()
        {
            // Arrange
            var sut = new SeasonFinder();
            var dateProvider = new Mock<IDateProvider>();
            dateProvider.SetupGet(x => x.UtcNow).Returns(new DateTime(2010,6,1));

            // Act
            var result = sut.Find(dateProvider.Object);

            // Assert
            Assert.Equal(Season.Summer, result);
        }

        [Fact]
        public void TestWinter()
        {
            // Arrange
            var sut = new SeasonFinder();
            var dateProvider = new Mock<IDateProvider>();
            dateProvider.SetupGet(x => x.UtcNow).Returns(new DateTime(2010, 12, 1));

            // Act
            var result = sut.Find(dateProvider.Object);

            // Assert
            Assert.Equal(Season.Winter, result);
        }

        [Fact]
        public void TestFall()
        {
            // Arrange
            var sut = new SeasonFinder();
            var dateProvider = new Mock<IDateProvider>();
            dateProvider.SetupGet(x => x.UtcNow).Returns(new DateTime(2010, 9, 1));

            // Act
            var result = sut.Find(dateProvider.Object);

            // Assert
            Assert.Equal(Season.Fall, result);
        }

        [Fact]
        public void TestSpring()
        {
            // Arrange
            var sut = new SeasonFinder();
            var dateProvider = new Mock<IDateProvider>();
            dateProvider.SetupGet(x => x.UtcNow).Returns(new DateTime(2010, 5, 1));

            // Act
            var result = sut.Find(dateProvider.Object);

            // Assert
            Assert.Equal(Season.Spring, result);
        }


    }
}
