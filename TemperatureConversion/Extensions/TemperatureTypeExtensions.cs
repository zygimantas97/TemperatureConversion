using System;
using TemperatureConversion.TemperatureSystems;

namespace TemperatureConversion.Extensions
{
    public static class TemperatureTypeExtensions
    {
        public static TemperatureSystem Create(this TemperatureType type) => type switch
        {
            TemperatureType.K => new Kelvin(),
            TemperatureType.F => new Fahrenheit(),
            TemperatureType.C => new Celsius(),
            TemperatureType.G => new Green(),
            TemperatureType.O => new Orange(),
            _ => throw new ArgumentOutOfRangeException(nameof(type), "Unsupported temperature type.")
        };
    }
}
