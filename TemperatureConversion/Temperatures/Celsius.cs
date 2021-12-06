using System;
using System.Collections.Generic;
using System.Text;

namespace TemperatureConversion.Temperatures
{
    public class Celsius : Temperature
    {
        public override double FromKelvin(double degrees)
        {
            return degrees - 273.15;
        }

        public override double ToKelvin(double degrees)
        {
            return degrees + 273.15;
        }
    }
}
