using System;
using System.Collections.Generic;
using System.Text;

namespace TemperatureConversion.Temperatures
{
    public class Fahrenheit : Temperature
    {
        public override double FromKelvin(double degrees)
        {
            return (degrees - 273.15) * 9 / 5 + 32;
        }

        public override double ToKelvin(double degrees)
        {
            return (degrees - 32) * 5 / 9 + 273.15;
        }
     }
}
