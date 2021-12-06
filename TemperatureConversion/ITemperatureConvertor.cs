using System;
using System.Collections.Generic;
using System.Text;
using TemperatureConversion.Temperatures;

namespace TemperatureConversion
{
    public interface ITemperatureConvertor
    {
        double Convert(double degrees);
    }
}
