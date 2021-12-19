using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
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
            var maxDiff = 0.01;
            TemperatureSystem temperature = new Orange();

            var actualDegrees = temperature.FromKelvin(kelvinDegrees);

            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(100, 50)]
        public void ToKelvin(double orangeDegrees, double expectedDegrees)
        {
            var maxDiff = 0.01;
            TemperatureSystem temperature = new Orange();

            var actualDegrees = temperature.ToKelvin(orangeDegrees);

            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }
    }
}
