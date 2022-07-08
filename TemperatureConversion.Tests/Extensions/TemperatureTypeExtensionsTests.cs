using FluentAssertions;
using NUnit.Framework;
using System;
using TemperatureConversion.Extensions;
using TemperatureConversion.TemperatureSystems;

namespace TemperatureConversion.Tests.Extensions
{
    [TestFixture]
    public class TemperatureTypeExtensionsTests
    {
        [TestCase(TemperatureType.K, typeof(Kelvin))]
        [TestCase(TemperatureType.F, typeof(Fahrenheit))]
        [TestCase(TemperatureType.C, typeof(Celsius))]
        [TestCase(TemperatureType.G, typeof(Green))]
        [TestCase(TemperatureType.O, typeof(Orange))]
        public void Create_ReturnsTemperatureSystemOfExpectedType(
            TemperatureType temperatureType,
            Type expectedTemperatureSystemType)
        {
            // Arrange

            // Act
            var temperatureSystem = temperatureType.Create();

            // Assert
            temperatureSystem.Should().BeOfType(expectedTemperatureSystemType);
        }
    }
}
