using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TemperatureConversion.Temperatures;

namespace TemperatureConversion.Tests.Temperatures
{
    [TestFixture]
    public class KelvinTests
    {
        [Test]
        public void FromKelvin_WhenKelvin0_ReturnsSameDegrees()
        {
            var expectedDegrees = 0;
            Temperature temperature = new Kelvin();

            var actualDegrees = temperature.FromKelvin(expectedDegrees);

            actualDegrees.Should().Be(expectedDegrees);
        }

        [Test]
        public void FromKelvin_WhenKelvin100_ReturnsSameDegrees()
        {
            var expectedDegrees = 100;
            Temperature temperature = new Kelvin();

            var actualDegrees = temperature.FromKelvin(expectedDegrees);

            actualDegrees.Should().Be(expectedDegrees);
        }

        [Test]
        public void ToKelvin_WhenKelvin0_ReturnsSameDegrees()
        {
            var expectedDegrees = 0;
            Temperature temperature = new Kelvin();

            var actualDegrees = temperature.ToKelvin(expectedDegrees);

            actualDegrees.Should().Be(expectedDegrees);
        }

        [Test]
        public void ToKelvin_WhenKelvin100_ReturnsSameDegrees()
        {
            var expectedDegrees = 100;
            Temperature temperature = new Kelvin();

            var actualDegrees = temperature.ToKelvin(expectedDegrees);

            actualDegrees.Should().Be(expectedDegrees);
        }
    }
}
