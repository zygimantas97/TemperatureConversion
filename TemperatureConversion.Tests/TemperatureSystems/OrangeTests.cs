using FluentAssertions;
using NUnit.Framework;
using System;
using TemperatureConversion.TemperatureSystems;

namespace TemperatureConversion.Tests.TemperatureSystems
{
    [TestFixture]
    public class OrangeTests
    {
        [Test]
        [TestCase(0, 0)]
        [TestCase(100, 200)]
        public void FromKelvin(double kelvinDegrees, double expectedDegrees)
        {
            // Arrange
            var maxDiff = 0.01;
            TemperatureSystem temperature = new Orange();

            // Act
            var actualDegrees = temperature.FromKelvin(kelvinDegrees);

            // Assert
            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(100, 50)]
        public void ToKelvin(double orangeDegrees, double expectedDegrees)
        {
            // Arrange
            var maxDiff = 0.01;
            TemperatureSystem temperature = new Orange();

            // Act
            var actualDegrees = temperature.ToKelvin(orangeDegrees);

            // Assert
            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }
    }
}
