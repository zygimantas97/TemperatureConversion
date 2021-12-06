using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TemperatureConversion.Temperatures;

namespace TemperatureConversion.Tests.Temperatures
{
    [TestFixture]
    public class FahrenheitTests
    {
        [Test]
        public void FromKelvin_WhenKelvin0_ReturnsFahrenheitDegrees()
        {
            var kelvinDegrees = 0;
            var expectedDegrees = -459.67;
            var maxDiff = 0.01;
            Temperature temperature = new Fahrenheit();

            var actualDegrees = temperature.FromKelvin(kelvinDegrees);

            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }

        [Test]
        public void FromKelvin_WhenKelvin100_ReturnsFahrenheitDegrees()
        {
            var kelvinDegrees = 100;
            var expectedDegrees = -279.67;
            var maxDiff = 0.01;
            Temperature temperature = new Fahrenheit();

            var actualDegrees = temperature.FromKelvin(kelvinDegrees);

            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }

        [Test]
        public void ToKelvin_WhenFahrenheit0_ReturnsKelvinDegrees()
        {
            var fahrenheitDegrees = 0;
            var expectedDegrees = 255.37;
            var maxDiff = 0.01;
            Temperature temperature = new Fahrenheit();

            var actualDegrees = temperature.ToKelvin(fahrenheitDegrees);

            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }

        [Test]
        public void ToKelvin_WhenFahrenheit100_ReturnsKelvinDegrees()
        {
            var fahrenheitDegrees = 100;
            var expectedDegrees = 310.93;
            var maxDiff = 0.01;
            Temperature temperature = new Fahrenheit();

            var actualDegrees = temperature.ToKelvin(fahrenheitDegrees);

            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }
    }
}
