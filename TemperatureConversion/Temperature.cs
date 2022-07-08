using System;
using TemperatureConversion.Extensions;
using TemperatureConversion.TemperatureSystems;

namespace TemperatureConversion
{
    public class Temperature
    {
        public TemperatureSystem TemperatureSystem { get; set; }
        public double Degrees { get; set; }

        public static Temperature Parse(string temperatureExpression)
        {
            if (temperatureExpression == null)
                throw new ArgumentException("Provided expression can not be null.", nameof(temperatureExpression));

            var expressionParts = temperatureExpression.Split(" ");
            if (expressionParts.Length != 2)
                throw new ArgumentException("Provided expression is in wrong format.", nameof(temperatureExpression));

            return new Temperature
            {
                Degrees = double.Parse(expressionParts[0]),
                TemperatureSystem = Enum.Parse<TemperatureType>(expressionParts[1]).Create()
            };
        }
    }
}
