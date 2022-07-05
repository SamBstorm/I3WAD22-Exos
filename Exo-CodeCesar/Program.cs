using System;
using System.Collections.Generic;

namespace Exo_CodeCesar
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Version décomposée
            //Console.WriteLine("Quel est le message à encoder ?");
            //string message = Console.ReadLine();
            //char[] chars = message.ToCharArray();
            //string newMessage = "";
            //foreach (char c in chars)
            //{
            //    int charCode = (int)c;
            //    charCode += 2;
            //    char newC = (char)charCode;
            //    newMessage += newC;
            //}
            //Console.WriteLine($"Voici le message encrypté : \n\n\"{newMessage}\""); 
            #endregion
            #region Version simplifiée
            Console.WriteLine("Quel est le message à encoder ?");
            string message = Console.ReadLine();
            int cle;
            do
            {
                Console.WriteLine("Quel est le numéro clé?");
            } while (!int.TryParse(Console.ReadLine(), out cle) || cle <= 0);
            string encrypt;
            do
            {
                Console.WriteLine("Voulez-vous (E)ncrypter ou (D)écrypter ?");
                encrypt = Console.ReadLine();
            } while (encrypt != "E" && encrypt != "D" );
            string newMessage = "";
            cle = (encrypt == "D") ? cle * -1 : cle;
            foreach (char c in message)
            {
                newMessage += (char)(c + cle); //Si on veut du binaire (Merci Alessandra...) : Convert.ToString((c + cle),2)
            }
            Console.WriteLine($"Voici le message encrypté : \n\n\"{newMessage}\"");
            #endregion
        }
    }
}
