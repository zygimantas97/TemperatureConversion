using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
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
            var maxDiff = 0.01;
            TemperatureSystem temperature = new Celsius();

            var actualDegrees = temperature.FromKelvin(kelvinDegrees);

            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }

        [Test]
        [TestCase(0, 273.15)]
        [TestCase(100, 373.15)]
        public void ToKelvin(double celsiusDegrees, double expectedDegrees)
        {
            var maxDiff = 0.01;
            TemperatureSystem temperature = new Celsius();

            var actualDegrees = temperature.ToKelvin(celsiusDegrees);

            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }
    }
}
