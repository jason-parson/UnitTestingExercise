using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(3, 4, 7, 14)]
        [InlineData(200, 300, 500, 1000)]
        [InlineData(1, 2, 16, 19)]

        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var calculator = new UnitTestMethods();

            //Act

            var actual = calculator.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(200, 100, 100)]
        [InlineData(500, 250, 250)]
        [InlineData(60, 40, 20)]

        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange

            var calculator2 = new UnitTestMethods();

            //Act

            var actual = calculator2.Subtract(minuend, subtrhend);

            //Assert

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(68, 47, 3196)]
        [InlineData(9, 5, 45)]
        [InlineData(10, 10, 100)]

        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange

            var multiplication = new UnitTestMethods();
            //Act

            var actual = multiplication.Multiply(num1 , num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(21, 7, 3)]
        [InlineData(40, 10, 4)]
        [InlineData(500, 5, 100)]
        [InlineData(81,9,9)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange

            var divison = new UnitTestMethods();

            //Act

            var actual = divison.Divide(num1,num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void YourMethodName()
        {
            //Arrange

            //Act

            //Assert

        }

        [Fact]
        public void YourMethodName2()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}
