using System;

namespace Exo_EquationSecondDegre
{
    class Program
    {
        static void Main(string[] args)
        {
            Equation eq1;
            eq1.a = 1;
            eq1.b = -2;
            eq1.c = 1;

            double? X1, X2;

            if(eq1.Resoudre(out X1,out X2))
            {
                if (X1 == X2) Console.WriteLine($"{eq1.a}X² + {eq1.b}X + {eq1.c} est résolvable et X vaut {X1}.");
                else Console.WriteLine($"{eq1.a}X² + {eq1.b}X + {eq1.c} est résolvable et X peut être {X1} ou {X2}.");
            }
            else
            {
                Console.WriteLine($"{eq1.a}X² + {eq1.b}X + {eq1.c} n'est pas résolvable...");
            }
        }
    }
}
