using FluentAssertions;
using NUnit.Framework;
using System;
using TemperatureConversion.TemperatureSystems;

namespace TemperatureConversion.Tests.TemperatureSystems
{
    [TestFixture]
    public class CelsiusTests
    {
        [Test]
        [TestCase(0, -273.15)]
        [TestCase(100, -173.15)]
        public void FromKelvin(double kelvinDegrees, double expectedDegrees)
        {
            // Arrange
            var maxDiff = 0.01;
            TemperatureSystem temperature = new Celsius();

            // Act
            var actualDegrees = temperature.FromKelvin(kelvinDegrees);

            // Assert
            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }

        [Test]
        [TestCase(0, 273.15)]
        [TestCase(100, 373.15)]
        public void ToKelvin(double celsiusDegrees, double expectedDegrees)
        {
            // Arrange
            var maxDiff = 0.01;
            TemperatureSystem temperature = new Celsius();

            // Act
            var actualDegrees = temperature.ToKelvin(celsiusDegrees);

            // Assert
            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }
    }
}
