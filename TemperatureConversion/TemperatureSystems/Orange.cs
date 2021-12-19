using System;
using System.Collections.Generic;
using System.Text;

namespace TemperatureConversion.TemperatureSystems
{
    public class Orange : TemperatureSystem
    {
        public override double FromKelvin(double degrees)
        {
            return degrees * 2;
        }

        public override double ToKelvin(double degrees)
        {
            return degrees / 2;
        }
    }
}
