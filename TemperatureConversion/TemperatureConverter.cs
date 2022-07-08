using System;
using TemperatureConversion.TemperatureSystems;

namespace TemperatureConversion
{
    public class TemperatureConverter : ITemperatureConverter
    {
        private TemperatureSystem _from;
        private TemperatureSystem _to;

        public TemperatureConverter() {}

        public TemperatureConverter(TemperatureSystem from, TemperatureSystem to)
        {
            _from = from;
            _to = to;
        }

        public double Convert(double degrees)
        {
            if (_from == null || _to == null)
                throw new InvalidOperationException("Source (From) and/or destination (To) were not setted.");

            return Convert(_from, _to, degrees);
        }

        public Temperature Convert(Temperature temperature, TemperatureSystem to)
        {
            return new Temperature
            {
                TemperatureSystem = to,
                Degrees = Convert(temperature.TemperatureSystem, to, temperature.Degrees)
            };
        }

        public double Convert(TemperatureSystem from, TemperatureSystem to, double degrees)
        {
            return to.FromKelvin(from.ToKelvin(degrees));
        }

        public ITemperatureConverter From(TemperatureSystem from)
        {
            _from = from;
            return this;
        }

        public ITemperatureConverter To(TemperatureSystem to)
        {
            _to = to;
            return this;
        }
    }
}
