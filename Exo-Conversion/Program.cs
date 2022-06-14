using System;

namespace Exo_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exo int.Parse(...)
            //Console.WriteLine("Veuillez insérer un premier nombre :");
            ////string input_nb1 = Console.ReadLine();
            ////int nb1 = int.Parse(input_nb1);
            //int nb1 = int.Parse(Console.ReadLine());
            //Console.Clear();
            //Console.WriteLine("Entrez un autre nombre :");
            //int nb2 = int.Parse(Console.ReadLine());
            //Console.Clear();
            //Console.WriteLine($"{nb1} + {nb2} = {nb1 + nb2}");
            #endregion
            #region Exo int.TryParse(... , out ...)
            Console.WriteLine("Veuillez encoder le premier nombre :");
            string input = Console.ReadLine();
            int nb1;
            //int.TryParse(input_nb1, out nb1); //Pas besoin du booléen, donc pas de sauvegarde du résultat
            bool check = int.TryParse(input, out nb1);
            Console.WriteLine($"La conversion de {input} a réussi : {check}"); 
            Console.WriteLine("Entrez un second nombre :");
            input = Console.ReadLine();
            int nb2;
            check = int.TryParse(input, out nb2);
            Console.WriteLine($"La conversion de {input} a réussi : {check}");
            Console.WriteLine($"{nb1} + {nb2} = {nb1 + nb2}");
            #endregion

        }
    }
}
