using System;
using System.Collections.Generic;

namespace Exo_NbPremierOpti
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit;
            do
            {
                Console.WriteLine("Veuillez indiquer le nombre de nombre premier à récupérer :"); 
            } while (!int.TryParse(Console.ReadLine(), out limit) || limit <= 0 );

            List<int> primes = new List<int>();

            for (int nbTest = 2; primes.Count < limit; nbTest++)
            {
                bool nbIsPrime = true;
                for (int index = 0; primes.Count > 0 && primes[index]*primes[index] <= nbTest && nbIsPrime; index++)
                {
                    if (nbTest % primes[index] == 0) nbIsPrime = false;
                }
                if (nbIsPrime) primes.Add(nbTest);
            }

            foreach (int prime in primes)
            {
                Console.WriteLine($"{prime} est un nombre premier...");
            }
        }
    }
}
