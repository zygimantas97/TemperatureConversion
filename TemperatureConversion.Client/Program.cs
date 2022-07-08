using System;
using TemperatureConversion.Extensions;

namespace TemperatureConversion.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHeader();
            var converter = new TemperatureConverter();
            var command = string.Empty;
            while (command.ToUpper() != "Q")
            {
                ExecuteTemperatureConversion(converter);
                command = GetNextCommand();
            }
        }

        private static void PrintHeader()
        {
            var headerLine = new String('-', 25);
            Console.WriteLine(headerLine);
            Console.WriteLine("| Temperature Converter |");
            Console.WriteLine(headerLine);
        }

        private static void ExecuteTemperatureConversion(ITemperatureConverter converter)
        {
            var temperatureConvertFrom = GetTemperatureConvertFrom();
            var temperatureTypeConvertTo = GetTemperatureTypeConvertTo();
            var temperatureSystemConvertTo = temperatureTypeConvertTo.Create();
            var temperatureResult = converter.Convert(temperatureConvertFrom, temperatureSystemConvertTo);
            PrintResult(temperatureTypeConvertTo, temperatureResult);
        }

        private static Temperature GetTemperatureConvertFrom()
        {
            Console.WriteLine("Enter temperature you want convert from (ex. '1 K'):");
            var temperatureExpression = Console.ReadLine();
            return Temperature.Parse(temperatureExpression);
        }

        private static TemperatureType GetTemperatureTypeConvertTo()
        {
            Console.WriteLine("Enter temperature system you want convert to (ex. 'C'):");
            var temperatureTypeExpression = Console.ReadLine();
            return Enum.Parse<TemperatureType>(temperatureTypeExpression);
        }

        private static void PrintResult(TemperatureType temperatureTypeConvertTo, Temperature temperatureResult)
        {
            Console.WriteLine($"{temperatureResult.Degrees} {temperatureTypeConvertTo}");
        }

        private static string GetNextCommand()
        {
            Console.WriteLine("If you want exit press 'Q' key, otherwise press any key to continue.");
            return Console.ReadLine();
        }
    }
}
