using System;
using TemperatureConversion.Extensions;

namespace TemperatureConversion.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature Converter");
            var converter = new TemperatureConverter();
            var command = string.Empty;
            while(command.ToUpper() != "Q")
            {
                Console.WriteLine("Enter temperature you want convert from (ex. '1 K'):");
                var temperatureExpression = Console.ReadLine();
                var temperature = Temperature.Parse(temperatureExpression);
                Console.WriteLine("Enter temperature system you want convert to (ex. 'C'):");
                var temperatureSystemExpression = Console.ReadLine();
                var temperatureSystem = Enum.Parse<TemperatureType>(temperatureSystemExpression).Create();

                var result = converter.Convert(temperature, temperatureSystem);
                Console.WriteLine($"{result.Degrees} {temperatureSystemExpression}");
                Console.WriteLine("If you want exit press 'Q' key, otherwise press any key to continue.");
                command = Console.ReadLine();
            }
        }
    }
}
