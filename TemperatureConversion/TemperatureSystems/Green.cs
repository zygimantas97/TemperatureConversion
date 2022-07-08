namespace TemperatureConversion.TemperatureSystems
{
    public class Green : TemperatureSystem
    {
        public override double FromKelvin(double degrees)
        {
            return degrees - 100;
        }

        public override double ToKelvin(double degrees)
        {
            return degrees + 100;
        }
    }
}
