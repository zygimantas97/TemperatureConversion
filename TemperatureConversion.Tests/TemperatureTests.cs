using FluentAssertions;
using FluentAssertions.Execution;
using NUnit.Framework;
using System;
using TemperatureConversion.TemperatureSystems;

namespace TemperatureConversion.Tests
{
    [TestFixture]
    public class TemperatureTests
    {
        [Test]
        public void Parse_WhenTemperatureExpressionNull_ThrowsArgumentException()
        {
            // Arrange

            // Act
            Action parse = () => Temperature.Parse(null);

            // Assert
            parse.Should().Throw<ArgumentException>()
                .WithMessage("Provided expression can not be null. (Parameter 'temperatureExpression')");
        }

        [TestCase("1")]
        [TestCase("1 1 K")]
        public void Parse_WhenTemperatureExpressionIsInWrongFormat_ThrowsArgumentException(
            string temperatureExpression)
        {
            // Arrange

            // Act
            Action parse = () => Temperature.Parse(temperatureExpression);

            // Assert
            parse.Should().Throw<ArgumentException>()
                .WithMessage("Provided expression is in wrong format. (Parameter 'temperatureExpression')");
        }

        [TestCase("1.5 K", 1.5, typeof(Kelvin))]
        [TestCase("1 F", 1, typeof(Fahrenheit))]
        [TestCase("0 C", 0, typeof(Celsius))]
        [TestCase("-1 G", -1, typeof(Green))]
        [TestCase("-1.5 O", -1.5, typeof(Orange))]
        public void Parse_WhenTemperatureExpressionIsInCorrectFormat_ReturnsTemperatureWithExpectedDegreesAndTemperatureSystem(
            string temperatureExpression,
            double expectedDegrees,
            Type expectedTemperatureSystemType)
        {
            // Arrange

            // Act
            var temperature = Temperature.Parse(temperatureExpression);

            // Assert
            using var _ = new AssertionScope();
            temperature.Degrees.Should().Be(expectedDegrees);
            temperature.TemperatureSystem.Should().BeOfType(expectedTemperatureSystemType);
        }
    }
}
