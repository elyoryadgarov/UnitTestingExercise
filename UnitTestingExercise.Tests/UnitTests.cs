using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(-3, 5, 5, 7)]
        [InlineData(5, 23, 6, 34)]
        [InlineData(-6, 0, -4, -10)]
        [InlineData(0, 0, 0, 0)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var calc = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = calc.Add(num1, num2, num3);

            //Assert
            //Assert.Equal(expected, actual);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(20,18,2)]//Add test data <-------
        [InlineData(0,5,-5)]
        [InlineData(-5,5,-10)]
        [InlineData(14,8,6)]
        [InlineData(11,11,0)]
        [InlineData(8,-8,16)]
        
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var calc = new Calculator();
            //Act
            var actual = calc.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2,4,8)]//Add test data <-------
        [InlineData(4,5,20)]
        [InlineData(0,4,0)]
        [InlineData(3,0,0)]
        [InlineData(-6,4,-24)]
        [InlineData(2,-5,-10)]
        
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var calc = new Calculator();

            //Act
            var actual = calc.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(7,3,2)]//Add test data <-------
        [InlineData(8,-2,-4)]
        [InlineData(14,0,0)]
        [InlineData(0,3,0)]
        [InlineData(-7,13,0)]
        [InlineData(15,3,5)]
        
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calc = new Calculator();

            //Act
            var actual = calc.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
