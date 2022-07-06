using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_CelsiusFahrenheit
{
    public struct Celsius {
        public double temperature;
        public Fahrenheit Conversion()
        {
            Fahrenheit f;
            f.temperature = (this.temperature * 9 / 5) + 32;
            return f;
        }
    }

    public struct Fahrenheit
    {
        public double temperature;
        public Celsius Conversion()
        {
            Celsius c;
            c.temperature = (this.temperature - 32) * 5 / 9;
            return c;
        }
    }
}
