using System;

namespace Exo_BBAN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour! Veuillez introduire votre numéro BBAN (12 chiffres):");
            string bban = Console.ReadLine();
            if (
                (bban.Length == 12 && long.TryParse(bban, out _)) //SOIT BBAN (12 chiffres)
                || 
                (bban.Length == 16 && long.TryParse(bban.Substring(bban.Length-14), out _))) //SOIT IBAN 2 Lettres + 14 chiffres
            {
                string twoLast = bban.Substring(bban.Length - 2);
                if (twoLast == "00" || twoLast == "98" || twoLast == "99") Console.WriteLine("KO"); // Plus facile de prouver que le compte n'est pas valide, si celui-ci se termine par 00, 98 ou 99, alors il n'est pas valide, pas besoin de calcul ou de convertion pour le prouver...
                else
                {
                    string tenFirst = bban.Substring(bban.Length - 12, 10);
                    long tenNumber = long.Parse(tenFirst);
                    short twoNumber = short.Parse(twoLast);
                    short modulo = (short)(tenNumber % 97);
                    if (twoNumber == modulo || (modulo == 0 && twoNumber == 97)) Console.WriteLine("OK");
                    else Console.WriteLine("KO");
                }
            }
            else
            {
                Console.WriteLine($"Votre numéro BBAN '{bban}' ne semble pas valide... ");
            }
        }
    }
}
