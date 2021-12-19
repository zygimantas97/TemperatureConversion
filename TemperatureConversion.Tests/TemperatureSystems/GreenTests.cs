﻿using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
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
            var maxDiff = 0.01;
            TemperatureSystem temperature = new Green();

            var actualDegrees = temperature.FromKelvin(kelvinDegrees);

            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }

        [Test]
        [TestCase(0, 100)]
        [TestCase(100, 200)]
        public void ToKelvin_WhenGreen0_ReturnsKelvinDegrees(double greenDegrees, double expectedDegrees)
        {
            var maxDiff = 0.01;
            TemperatureSystem temperature = new Green();

            var actualDegrees = temperature.ToKelvin(greenDegrees);

            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }
    }
}
