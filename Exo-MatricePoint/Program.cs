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
                        Point p = (Point)tab[row, col];
                        Console.Write($"X : {p.x} - Y : {p.y}");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
