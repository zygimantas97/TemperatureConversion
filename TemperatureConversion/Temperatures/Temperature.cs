using System;
using System.Collections.Generic;
using System.Text;

namespace TemperatureConversion.Temperatures
{
    public abstract class Temperature
    {
        public abstract double ToKelvin(double degrees);
        public abstract double FromKelvin(double degrees);
    }
}
