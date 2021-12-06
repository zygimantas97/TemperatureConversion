using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TemperatureConversion.Temperatures;

namespace TemperatureConversion.Tests
{
    [TestFixture]
    public class TemperatureConvertorTests
    {
        [Test]
        public void ConvertFromKelvinToCelsius_WhenKelvin0_ReturnCelsiusDegrees()
        {
            var from = new Kelvin();
            var to = new Celsius();
            ITemperatureConvertor converter = new TemperatureConverter(from, to);
            var kelvinDegrees = 0;
            var expectedDegrees = -273.15;
            var maxDiff = 0.01;

            var actualDegrees = converter.Convert(kelvinDegrees);

            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }

        [Test]
        public void ConvertFromKelvinToCelsius_WhenKelvin100_ReturnCelsiusDegrees()
        {
            var from = new Kelvin();
            var to = new Celsius();
            ITemperatureConvertor converter = new TemperatureConverter(from, to);
            var kelvinDegrees = 100;
            var expectedDegrees = -173.15;
            var maxDiff = 0.01;

            var actualDegrees = converter.Convert(kelvinDegrees);

            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }

        [Test]
        public void ConvertFromKelvinToFahrenheit_WhenKelvin0_ReturnFahrenheitDegrees()
        {
            var from = new Kelvin();
            var to = new Fahrenheit();
            ITemperatureConvertor converter = new TemperatureConverter(from, to);
            var kelvinDegrees = 0;
            var expectedDegrees = -459.67;
            var maxDiff = 0.01;

            var actualDegrees = converter.Convert(kelvinDegrees);

            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }

        [Test]
        public void ConvertFromKelvinToFahrenheit_WhenKelvin100_ReturnFahrenheitDegrees()
        {
            var from = new Kelvin();
            var to = new Fahrenheit();
            ITemperatureConvertor converter = new TemperatureConverter(from, to);
            var kelvinDegrees = 100;
            var expectedDegrees = -279.67;
            var maxDiff = 0.01;

            var actualDegrees = converter.Convert(kelvinDegrees);

            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }

        [Test]
        public void ConvertFromFahrenheitToKelvin_WhenFahrenheit0_ReturnsKelvinDegrees()
        {
            var from = new Fahrenheit();
            var to = new Kelvin();
            ITemperatureConvertor converter = new TemperatureConverter(from, to);
            var kelvinDegrees = 0;
            var expectedDegrees = 255.37;
            var maxDiff = 0.01;

            var actualDegrees = converter.Convert(kelvinDegrees);

            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }

        [Test]
        public void ConvertFromFahrenheitToKelvin_WhenFahrenheit100_ReturnsKelvinDegrees()
        {
            var from = new Fahrenheit();
            var to = new Kelvin();
            ITemperatureConvertor converter = new TemperatureConverter(from, to);
            var kelvinDegrees = 100;
            var expectedDegrees = 310.93;
            var maxDiff = 0.01;

            var actualDegrees = converter.Convert(kelvinDegrees);

            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }

        [Test]
        public void ConvertFromFahrenheitToCelsius_WhenFahrenheit0_ReturnsCelsiusDegrees()
        {
            var from = new Fahrenheit();
            var to = new Celsius();
            ITemperatureConvertor converter = new TemperatureConverter(from, to);
            var kelvinDegrees = 0;
            var expectedDegrees = -17.78;
            var maxDiff = 0.01;

            var actualDegrees = converter.Convert(kelvinDegrees);

            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }

        [Test]
        public void ConvertFromFahrenheitToCelsius_WhenFahrenheit100_ReturnsCelsiusDegrees()
        {
            var from = new Fahrenheit();
            var to = new Celsius();
            ITemperatureConvertor converter = new TemperatureConverter(from, to);
            var kelvinDegrees = 100;
            var expectedDegrees = 37.78;
            var maxDiff = 0.01;

            var actualDegrees = converter.Convert(kelvinDegrees);

            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }

        [Test]
        public void ConvertFromCelsiusToKelvin_WhenCelsius0_ReturnsKelvinDegrees()
        {
            var from = new Celsius();
            var to = new Kelvin();
            ITemperatureConvertor converter = new TemperatureConverter(from, to);
            var kelvinDegrees = 0;
            var expectedDegrees = 273.15;
            var maxDiff = 0.01;

            var actualDegrees = converter.Convert(kelvinDegrees);

            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }

        [Test]
        public void ConvertFromCelsiusToKelvin_WhenCelsius100_ReturnsKelvinDegrees()
        {
            var from = new Celsius();
            var to = new Kelvin();
            ITemperatureConvertor converter = new TemperatureConverter(from, to);
            var kelvinDegrees = 100;
            var expectedDegrees = 373.15;
            var maxDiff = 0.01;

            var actualDegrees = converter.Convert(kelvinDegrees);

            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }

        [Test]
        public void ConvertFromCelsiusToFahrenheit_WhenCelsius0_ReturnsFahrenheitDegrees()
        {
            var from = new Celsius();
            var to = new Fahrenheit();
            ITemperatureConvertor converter = new TemperatureConverter(from, to);
            var kelvinDegrees = 0;
            var expectedDegrees = 32;
            var maxDiff = 0.01;

            var actualDegrees = converter.Convert(kelvinDegrees);

            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }

        [Test]
        public void ConvertFromCelsiusToFahrenheit_WhenCelsius100_ReturnsFahrenheitDegrees()
        {
            var from = new Celsius();
            var to = new Fahrenheit();
            ITemperatureConvertor converter = new TemperatureConverter(from, to);
            var kelvinDegrees = 100;
            var expectedDegrees = 212;
            var maxDiff = 0.01;

            var actualDegrees = converter.Convert(kelvinDegrees);

            var diff = Math.Abs(expectedDegrees - actualDegrees);
            diff.Should().BeLessThan(maxDiff);
        }
    }
}
