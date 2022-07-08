namespace TemperatureConversion.TemperatureSystems
{
    public class Celsius : TemperatureSystem
    {
        public override double FromKelvin(double degrees)
        {
            return degrees - 273.15;
        }

        public override double ToKelvin(double degrees)
        {
            return degrees + 273.15;
        }
    }
}
