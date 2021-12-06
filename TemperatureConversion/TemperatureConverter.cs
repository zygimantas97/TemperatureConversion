using System;
using System.Collections.Generic;
using System.Text;
using TemperatureConversion.Temperatures;

namespace TemperatureConversion
{
    public class TemperatureConverter : ITemperatureConvertor
    {
        private Temperature _from;
        private Temperature _to;

        public TemperatureConverter(Temperature from, Temperature to)
        {
            _from = from;
            _to = to;
        }

        public double Convert(double degrees)
        {
            return _to.FromKelvin(_from.ToKelvin(degrees));
        }
    }
}
