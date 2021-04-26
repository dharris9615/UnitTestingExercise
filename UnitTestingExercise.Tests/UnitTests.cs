using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2,4,6,12)]
        [InlineData(3,4,5,12)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var Add = new UnitTestMethods();

            //Act
            var actual = Add.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,5,5)]
        [InlineData(20,14,6)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var sub = new UnitTestMethods();

            //Act
            var actual = sub.Sub(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(7,7,49)]
        [InlineData(5, 10, 50)]
        [InlineData(2,7,14)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var mult = new UnitTestMethods();

            //Act
            var actual = mult.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(100,10,10)]
        [InlineData(45,9,5)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var div = new UnitTestMethods();

            //Act
            var actual = div.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void YourMethodName()
        {
            //Arrange
            var subject = new UnitTestMethods();

            //Act
            var actual = subject.Class();

            //Assert
            Assert.Equal("TrueCoders", actual);
        }

        [Fact]
        public void YourMethodName2()
        {
            //Arrange
            var name = new UnitTestMethods();

            //Act
            var actual = name.Name();

            //Assert
            Assert.Equal("David", actual);
        }
    }
}
