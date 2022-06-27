using System;

namespace CorrectionExosBoucles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exos 1 Fibonacci

            //int pn = 1;
            //int sn = 1;
            //int nbUser;

            //Console.WriteLine("Suite de Fibonacci");


            //do
            //{
            //    Console.WriteLine("Veuillez entrer le nombre de suite voulue : ");
            //    nbUser = int.Parse(Console.ReadLine());
            //}
            //while (nbUser > 25);

            //Console.WriteLine("--------------------------------------------------");
            //Console.WriteLine(pn);
            //Console.WriteLine(sn);

            //for (int i = 0; i < nbUser-2 ; i++)
            //{
            //    int current = pn + sn;
            //    Console.WriteLine(current);
            //    pn = sn;
            //    sn = current;
            //}
            #endregion

            #region Exos 2 Factoriel
            //int nb;
            //long result;

            //Console.WriteLine("Factoriel");

            //do
            //{
            //    Console.WriteLine("Veuillez entrer un nombre a pour découvrir sa factoriel");
            //    nb = int.Parse(Console.ReadLine());
            //}
            //while (nb < 0 && nb < 17);

            //result = nb--;

            //while(nb > 1)
            //{
            //    result *= nb--;
            //}

            //Console.WriteLine(result);
            #endregion

            #region Exos 3 Nombre premier

            //int nb;

            //Console.WriteLine("Nombre premier");

            //do
            //{
            //    Console.WriteLine("Veuillez saisir un nombre :");
            //    nb = int.Parse(Console.ReadLine());
            //}
            //while (nb <= 0);

            //for(int count = 0, value = 2; count < nb; value++)
            //{
            //    bool isPrime = true;

            //    int sqrt = (int)Math.Sqrt(value);

            //    for(int diviseur = 2; diviseur <= sqrt && isPrime; diviseur++)
            //    {
            //        if(value % diviseur == 0)
            //        {
            //            isPrime = false;
            //        }
            //    }

            //    if(isPrime)
            //    {
            //        Console.WriteLine(value);
            //        count++;
            //    }
            //}


            #endregion

            #region Exos 4 Table de multiplication

            //for(int multiplicateur = 1; multiplicateur <= 5; multiplicateur++)
            //{
            //    for(int nbre = 1; nbre <= 20; nbre++)
            //    {
            //        int result = nbre * multiplicateur;

            //        Console.WriteLine($"{nbre} * {multiplicateur} = {result}");
            //    }
            //    Console.WriteLine("--------------------");
            //}


            #endregion

            #region Exos 5 Increment 0.1
            //for(double tmp = 0D; tmp <= 20D; tmp += .1D)
            //{
            //    Console.WriteLine(tmp);
            //}


            //for (decimal tmp = 0M; tmp <= 20m; tmp += .1M)
            //{
            //    Console.WriteLine(tmp);
            //}
            #endregion

            #region Exos 6 Racine Carrée
            //decimal maxError = decimal.Zero;
            //decimal a = 71214.28M;
            //decimal startValue = a;
            //decimal currentValue = a;
            //decimal error = a;
            ////Tant que nous somme au dessus de l'erreur prévue
            //while (error > maxError)
            //{
            //    //la racine carré =
            //    //0.5 * (le chiffre trouvé + (le nombre de départ/le chiffre trouvé)  )
            //    currentValue = 0.5M * (currentValue + (a / currentValue));
            //    //Calcul du pas pour savoir si on s'approche du taux d'erreur permis
            //    //le pas c'est le (chiffre de départ - le chiffre trouvé)/chiffre de départ
            //    error = (startValue - currentValue) / startValue;
            //    //on recommencera le calcul à partir du chiffre trouvé
            //    startValue = currentValue;
            //    Console.WriteLine("pas=" + error + " racine=" + currentValue);
            //}

            //Console.WriteLine(currentValue.ToString("N10"));
            #endregion


        }
    }
}
