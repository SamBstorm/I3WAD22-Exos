using System;

namespace Exo_PierrePapierCiseaux
{
    class Program
    {
        static Random RNG = new Random();
        static void Main(string[] args)
        {
            #region Version Prof
            //Console.WriteLine("BIENVENU AU PIERRE PAPIER CISEAUX\n\nVeuillez choisir votre arme :\n(1) Pierre\n(2) Papier\n(3) Ciseaux");
            //int user_choice;
            //string input = Console.ReadLine();
            //if (int.TryParse(input, out user_choice) && user_choice >= 1 && user_choice <= 3)
            //{
            //    int cpu_choice = RNG.Next(1, 4);
            //    string message = "";
            //    switch (user_choice)
            //    {
            //        case 1:
            //            message = "YOU : Pierre - ";
            //            break;
            //        case 2:
            //            message = "YOU : Papier - ";
            //            break;
            //        case 3:
            //            message = "YOU : Ciseaux - ";
            //            break;
            //    }
            //    switch (cpu_choice)
            //    {
            //        case 1:
            //            message = message + "CPU : Pierre";
            //            break;
            //        case 2:
            //            message = message + "CPU : Papier";
            //            break;
            //        case 3:
            //            message = message + "CPU : Ciseaux";
            //            break;
            //    }
            //    Console.WriteLine(message);
            //    if (cpu_choice == user_choice) Console.WriteLine("Égalité!");
            //    else if ((cpu_choice == 1 && user_choice == 3) || (cpu_choice == 2 && user_choice == 1) || (cpu_choice == 3 && user_choice == 2))
            //        Console.WriteLine("CPU WIN...");
            //    else Console.WriteLine("YOU WIN !");
            //}
            //else
            //{
            //    Console.WriteLine("Reviens quand tu sauras lire...");
            //}
            #endregion

            #region Version de Nastya

            Console.WriteLine("BIENVENU AU PIERRE PAPIER CISEAUX\n\nVeuillez choisir votre arme :\n(1) Pierre\n(2) Papier\n(3) Ciseaux");
            int user_choice;
            string input = Console.ReadLine();
            if (int.TryParse(input, out user_choice) && user_choice >= 1 && user_choice <= 3)
            {
                int cpu_choice = RNG.Next(1, 4);
                string message = "";
                switch (user_choice)
                {
                    case 1:
                        message = "YOU : Pierre - ";
                        break;
                    case 2:
                        message = "YOU : Papier - ";
                        break;
                    case 3:
                        message = "YOU : Ciseaux - ";
                        break;
                }
                switch (cpu_choice)
                {
                    case 1:
                        message = message + "CPU : Pierre";
                        break;
                    case 2:
                        message = message + "CPU : Papier";
                        break;
                    case 3:
                        message = message + "CPU : Ciseaux";
                        break;
                }
                Console.WriteLine(message);
                if (cpu_choice == user_choice) Console.WriteLine("Égalité!");
                else if (((user_choice+1) % 4) == cpu_choice )
                    Console.WriteLine("CPU WIN...");
                else Console.WriteLine("YOU WIN !");
            }
            else
            {
                Console.WriteLine("Reviens quand tu sauras lire...");
            }

            #endregion
        }
    }
}
