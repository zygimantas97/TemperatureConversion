using System;
using System.Collections.Generic;
using System.Text;
using TemperatureConversion.TemperatureSystems;

namespace TemperatureConversion
{
    public class TemperatureType
    {
        public static readonly TemperatureSystem K = new Kelvin();
        public static readonly TemperatureSystem C = new Celsius();
        public static readonly TemperatureSystem F = new Fahrenheit();
        public static readonly TemperatureSystem G = new Green();
        public static readonly TemperatureSystem O = new Orange();
    }
}
