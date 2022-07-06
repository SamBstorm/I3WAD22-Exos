using System;

namespace Exo_CelsiusFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Celsius c;
            c.temperature = 21;
            Console.WriteLine($"{c.temperature}°C vaut {c.Conversion().temperature}°F.");


            Fahrenheit f;
            f.temperature = 210;
            Console.WriteLine($"{f.temperature}°F vaut {f.Conversion().temperature}°C.");
        }
    }
}
