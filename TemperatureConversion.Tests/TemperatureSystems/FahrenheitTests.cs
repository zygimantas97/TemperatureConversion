using FluentAssertions;
using NUnit.Framework;
using System;
using TemperatureConversion.TemperatureSystems;

namespace TemperatureConversion.Tests.TemperatureSystems
{
    [TestFixture]
    public class FahrenheitTests
    {
        [Test]
        [TestCase(0, -459.67)]
        [TestCase(100, -279.67)]
        public void FromKelvin(double kelvinDegrees, double expectedDegrees)
        {
            // Arrange
            var maxDiff = 0.01;
            TemperatureSystem temperature = new Fahrenheit();

            // Act
            var actualDegrees = temperature.FromKelvin(kelvinDegrees);

            // Assert
            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }

        [Test]
        [TestCase(0, 255.37)]
        [TestCase(100, 310.93)]
        public void ToKelvin(double fahrenheitDegrees, double expectedDegrees)
        {
            // Arrange
            var maxDiff = 0.01;
            TemperatureSystem temperature = new Fahrenheit();

            // Act
            var actualDegrees = temperature.ToKelvin(fahrenheitDegrees);

            // Assert
            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }
    }
}
