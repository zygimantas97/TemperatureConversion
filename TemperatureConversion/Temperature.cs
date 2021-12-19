using System;
using System.Collections.Generic;
using System.Text;
using TemperatureConversion.TemperatureSystems;

namespace TemperatureConversion
{
    public class Temperature
    {
        public TemperatureSystem TemperatureSystem { get; set; }
        public double Degrees { get; set; }
    }
}
