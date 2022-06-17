using System;

namespace Exo_PairImpair
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string input = Console.ReadLine();
            if (int.TryParse(input, out i))
            {
                int moitie = i / 2;
                if (i == moitie + moitie)
                {
                    Console.WriteLine($"Le nombre {i} est pair!");
                }
                else {
                    Console.WriteLine($"Le nombre {i} est impair!");
                }
            }
            else {
                Console.WriteLine($"L'entrée \"{input}\" n'est pas compatible...");
            }
        }
    }
}
