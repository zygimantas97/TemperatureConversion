using FluentAssertions;
using NUnit.Framework;
using TemperatureConversion.TemperatureSystems;

namespace TemperatureConversion.Tests.TemperatureSystems
{
    [TestFixture]
    public class KelvinTests
    {
        [Test]
        [TestCase(0)]
        [TestCase(100)]
        public void FromKelvin(double expectedDegrees)
        {
            // Arrange
            TemperatureSystem temperature = new Kelvin();

            // Act
            var actualDegrees = temperature.FromKelvin(expectedDegrees);

            // Assert
            actualDegrees.Should().Be(expectedDegrees);
        }

        [Test]
        [TestCase(0)]
        [TestCase(100)]
        public void ToKelvin(double expectedDegrees)
        {
            // Arrange
            TemperatureSystem temperature = new Kelvin();

            // Act
            var actualDegrees = temperature.ToKelvin(expectedDegrees);

            // Assert
            actualDegrees.Should().Be(expectedDegrees);
        }
    }
}
