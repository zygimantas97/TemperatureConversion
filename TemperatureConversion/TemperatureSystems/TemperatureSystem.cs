using System;
using System.Collections.Generic;
using System.Text;

namespace TemperatureConversion.TemperatureSystems
{
    public abstract class TemperatureSystem
    {
        public abstract double ToKelvin(double degrees);
        public abstract double FromKelvin(double degrees);
    }
}
