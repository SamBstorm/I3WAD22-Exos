using System;

namespace Exo_Divisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez indiquer un permier nombre :");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int a))
            {
                Console.WriteLine("Veuillez introduire un second nombre :");
                input = Console.ReadLine();
                if (int.TryParse(input, out int b) && b != 0) {
                    Console.WriteLine($"Division entière : { a / b } \t Modulo : { a % b } \t Division : { (double) a / b }");
                }
                else { Console.WriteLine($"Le nombre {input} n'est pas valide..."); }
            }
            else { Console.WriteLine($"Le nombre {input} n'est pas valide..."); }
        }
    }
}
