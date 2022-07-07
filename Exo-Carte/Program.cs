using System;

namespace Exo_Carte
{
    class Program
    {
        static void Main(string[] args)
        {
            Carte[] deck = new Carte[52];

            int i = 0;
            foreach (string colorName in Enum.GetNames<Couleurs>())
            {
                Couleurs color = Enum.Parse<Couleurs>(colorName);
                foreach (Valeurs value in Enum.GetValues<Valeurs>())
                {
                    //    deck[i].couleur = color;
                    //    deck[i].valeur = value;
                    Carte newCarte;
                    newCarte.couleur = color;
                    newCarte.valeur = value;
                    deck[i] = newCarte;
                    i++;
                }
            }

            foreach (Carte carte in deck)
            {
                Console.WriteLine($"{carte.valeur} de {carte.couleur}");
            }
        }
    }
}
