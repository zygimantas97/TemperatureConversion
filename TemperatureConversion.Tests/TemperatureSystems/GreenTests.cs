using FluentAssertions;
using NUnit.Framework;
using System;
using TemperatureConversion.TemperatureSystems;

namespace TemperatureConversion.Tests.TemperatureSystems
{
    [TestFixture]
    public class GreenTests
    {
        [Test]
        [TestCase(0, -100)]
        [TestCase(100, 0)]
        public void FromKelvin(double kelvinDegrees, double expectedDegrees)
        {
            // Arrange
            var maxDiff = 0.01;
            TemperatureSystem temperature = new Green();

            // Act
            var actualDegrees = temperature.FromKelvin(kelvinDegrees);

            // Assert
            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }

        [Test]
        [TestCase(0, 100)]
        [TestCase(100, 200)]
        public void ToKelvin_WhenGreen0_ReturnsKelvinDegrees(double greenDegrees, double expectedDegrees)
        {
            // Arrange
            var maxDiff = 0.01;
            TemperatureSystem temperature = new Green();

            // Act
            var actualDegrees = temperature.ToKelvin(greenDegrees);

            // Assert
            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }
    }
}
