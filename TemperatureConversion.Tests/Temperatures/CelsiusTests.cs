using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TemperatureConversion.Temperatures;

namespace TemperatureConversion.Tests.Temperatures
{
    [TestFixture]
    public class CelsiusTests
    {
        [Test]
        public void FromKelvin_WhenKelvin0_ReturnsCelsiusDegrees()
        {
            var kelvinDegrees = 0;
            var expectedDegrees = -273.15;
            var maxDiff = 0.01;
            Temperature temperature = new Celsius();

            var actualDegrees = temperature.FromKelvin(kelvinDegrees);

            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }

        [Test]
        public void FromKelvin_WhenKelvin100_ReturnsCelsiusDegrees()
        {
            var kelvinDegrees = 100;
            var expectedDegrees = -173.15;
            var maxDiff = 0.01;
            Temperature temperature = new Celsius();

            var actualDegrees = temperature.FromKelvin(kelvinDegrees);

            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }

        [Test]
        public void ToKelvin_WhenCelsius0_ReturnsKelvinDegrees()
        {
            var celsiusDegrees = 0;
            var expectedDegrees = 273.15;
            var maxDiff = 0.01;
            Temperature temperature = new Celsius();

            var actualDegrees = temperature.ToKelvin(celsiusDegrees);

            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }

        [Test]
        public void ToKelvin_WhenCelsius100_ReturnsKelvinDegrees()
        {
            var celsiusDegrees = 100;
            var expectedDegrees = 373.15;
            var maxDiff = 0.01;
            Temperature temperature = new Celsius();

            var actualDegrees = temperature.ToKelvin(celsiusDegrees);

            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }
    }
}
