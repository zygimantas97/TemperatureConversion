using System;
using System.Collections.Generic;
using System.Text;

namespace TemperatureConversion.TemperatureSystems
{
    public class Kelvin : TemperatureSystem
    {
        public override double FromKelvin(double degrees)
        {
            return degrees;
        }

        public override double ToKelvin(double degrees)
        {
            return degrees;
        }
    }
}
