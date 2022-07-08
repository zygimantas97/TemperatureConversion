using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TemperatureConversion.TemperatureSystems;

namespace TemperatureConversion.Tests
{
    [TestFixture]
    public class TemperatureConverterTests
    {
        [Test]
        [TestCase(0, -273.15)]
        [TestCase(100, -173.15)]
        public void ConvertFromKelvinToCelsius(double kelvinDegrees, double expectedDegrees)
        {
            var from = TemperatureType.K.Create();
            var to = TemperatureType.C.Create();
            ITemperatureConverter converter = new TemperatureConverter(from, to);
            var maxDiff = 0.01;

            var actualDegrees = converter.Convert(kelvinDegrees);

            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }

        [Test]
        [TestCase(0, -459.67)]
        [TestCase(100, -279.67)]
        public void ConvertFromKelvinToFahrenheit(double kelvinDegrees, double expectedDegrees)
        {
            var from = TemperatureType.K.Create();
            var to = TemperatureType.F.Create();
            ITemperatureConverter converter = new TemperatureConverter(from, to);
            var maxDiff = 0.01;

            var actualDegrees = converter.Convert(kelvinDegrees);

            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }

        [Test]
        [TestCase(0, 255.37)]
        [TestCase(100, 310.93)]
        public void ConvertFromFahrenheitToKelvin(double fahrenheitDegrees, double expectedDegrees)
        {
            var from = TemperatureType.F.Create();
            var to = TemperatureType.K.Create();
            ITemperatureConverter converter = new TemperatureConverter(from, to);
            var maxDiff = 0.01;

            var actualDegrees = converter.Convert(fahrenheitDegrees);

            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }

        [Test]
        [TestCase(0, -17.78)]
        [TestCase(100, 37.78)]
        public void ConvertFromFahrenheitToCelsius(double fahrenheitDegrees, double expectedDegrees)
        {
            var from = TemperatureType.F.Create();
            var to = TemperatureType.C.Create();
            ITemperatureConverter converter = new TemperatureConverter(from, to);
            var maxDiff = 0.01;

            var actualDegrees = converter.Convert(fahrenheitDegrees);

            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }

        [Test]
        [TestCase(0, 273.15)]
        [TestCase(100, 373.15)]
        public void ConvertFromCelsiusToKelvin(double celsiusDegrees, double expectedDegrees)
        {
            var from = TemperatureType.C.Create();
            var to = TemperatureType.K.Create();
            ITemperatureConverter converter = new TemperatureConverter(from, to);
            var maxDiff = 0.01;

            var actualDegrees = converter.Convert(celsiusDegrees);

            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }

        [Test]
        [TestCase(0, 32)]
        [TestCase(100, 212)]
        public void ConvertFromCelsiusToFahrenheit(double celsiusDegrees, double expectedDegrees)
        {
            var from = TemperatureType.C.Create();
            var to = TemperatureType.F.Create();
            ITemperatureConverter converter = new TemperatureConverter(from, to);
            var maxDiff = 0.01;

            var actualDegrees = converter.Convert(celsiusDegrees);

            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }

        [Test]
        [TestCase(0, -173.15)]
        [TestCase(100, -73.15)]
        public void ConvertFromGreenToCelsius(double greenDegrees, double expectedDegrees)
        {
            var from = TemperatureType.G.Create();
            var to = TemperatureType.C.Create();
            var temperature = new Temperature { TemperatureSystem = from, Degrees = greenDegrees };
            ITemperatureConverter converter = new TemperatureConverter();
            var maxDiff = 0.01;

            var actualDegrees = converter.Convert(temperature, to).Degrees;

            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }

        [Test]
        [TestCase(0, -273.15)]
        [TestCase(100, -223.15)]
        public void ConvertFromOrangeToCelsius(double orangeDegrees, double expectedDegrees)
        {
            var from = TemperatureType.O.Create();
            var to = TemperatureType.C.Create();
            var temperature = new Temperature { TemperatureSystem = from, Degrees = orangeDegrees };
            ITemperatureConverter converter = new TemperatureConverter();
            var maxDiff = 0.01;

            var actualDegrees = converter.Convert(temperature, to).Degrees;

            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }

        [Test]
        public void Convert_WhenSourceAndDetinationNotSetted_ThrowsInvalidOperationException()
        {
            var degrees = 100;
            ITemperatureConverter converter = new TemperatureConverter();

            converter.Invoking(x => x.Convert(degrees)).Should().Throw<InvalidOperationException>()
                .WithMessage("Source (From) and/or destination (To) were not setted.");
        }
    }
}
