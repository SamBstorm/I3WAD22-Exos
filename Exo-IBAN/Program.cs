using System;

namespace Exo_IBAN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez introduire votre BBAN (12 chiffres) :");

            string bban = Console.ReadLine();
            if (bban.Length == 12 && long.TryParse(bban, out _))
            {
                string recup = bban.Substring(10);
                string code = recup + recup + "111400";
                long codeTrans = long.Parse(code);
                short numBe = (short)(98 - (codeTrans % 97));
                Console.WriteLine($"BE{((numBe<10)?"0"+numBe:numBe)}{bban}");
            }
            else
            {
                Console.WriteLine($"Votre BBAN '{bban}' n'est pas valide...");
            }
        }
    }
}
