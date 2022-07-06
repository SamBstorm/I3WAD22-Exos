using System;

namespace Exo_MatricePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TAILLE = 5;
            Point?[,] tab = new Point?[TAILLE, TAILLE];

            for (int i = 0; i < TAILLE; i++)
            {
                Point p;
                p.x = i + 1;
                p.y = i + 1;
                tab[i, i] = p;
            }

            for (int row = 0; row < TAILLE; row++)
            {
                for (int col = 0; col < TAILLE; col++)
                {
                    if (tab[row, col] is null) Console.Write("\t");
                    else
                    {
                        //Version casting (Car on a testé la nullité)
                        Point p = (Point)tab[row, col];
                        Console.Write($"X : {p.x} - Y : {p.y}");
                        /*
                        //Version test d'accès au membre (l'accès aux membres à l'aide de ?. permet de vérifier si le membre est accessible en cas de null - X et Y ne sont pas accessible dans un null)
                        Console.Write($"X : {tab[row,col]?.x} - Y : {tab[row, col]?.y}");
                        //Version test d'accès au membre (avec une variable pour mieux lire le code 😅)
                        Point? pNull = tab[row, col];
                        Console.Write($"X : {pNull?.x} - Y : {pNull?.y}");
                        */
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
