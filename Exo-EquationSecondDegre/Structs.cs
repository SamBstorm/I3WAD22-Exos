using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_EquationSecondDegre
{
    public struct Equation {
        public double a, b, c;

        public bool Resoudre(out double? x1, out double? x2)
        {
            double delta = (b * b) - (4 * a * c);

            if (delta < 0)
            {
                x1 = null;
                x2 = null;
                return false;
            }
            else if (delta == 0)
            {
                x1 = -b / (2 * a);
                x2 = x1;
                return true;
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return true;
            }
        }

        public bool ResoudreSimplifie(out double? x1, out double? x2)
        {
            double delta = (b * b) - (4 * a * c);
            x1 = x2 = null;
            if(delta < 0) return false;
            if (delta == 0) x1 = x2 = -b / (2 * a);
            else {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            }
            return true;
        }

        public bool ResoudreFinal(out double? x1, out double? x2)
        {
            double delta = (b * b) - (4 * a * c);
            x1 = x2 = null;
            if (delta < 0) return false;
            x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return true;
        }
    }
}
