using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
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
            TemperatureSystem temperature = new Kelvin();

            var actualDegrees = temperature.FromKelvin(expectedDegrees);

            actualDegrees.Should().Be(expectedDegrees);
        }

        [Test]
        [TestCase(0)]
        [TestCase(100)]
        public void ToKelvin(double expectedDegrees)
        {
            TemperatureSystem temperature = new Kelvin();

            var actualDegrees = temperature.ToKelvin(expectedDegrees);

            actualDegrees.Should().Be(expectedDegrees);
        }
    }
}
