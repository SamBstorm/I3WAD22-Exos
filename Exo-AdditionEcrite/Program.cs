using System;

namespace Exo_AdditionEcrite
{
    class Program
    {
        static void Main(string[] args)
        {
            string number1, number2;
            do
            {
                Console.WriteLine("Veuillez entrer votre premier nombre : ");
                number1 = Console.ReadLine();
            } while (!int.TryParse(number1, out _));

            do
            {
                Console.WriteLine("Veuillez entrer votre second nombre : ");
                number2 = Console.ReadLine();
            } while (!int.TryParse(number2, out _));

            if(number2.Length < number1.Length)
            {
                string temp = number1;
                number1 = number2;
                number2 = temp;
            }
            for (int i = number1.Length; i < number2.Length; i++)
            {
                //number1 = "0" + number1;
                number1 = $"0{number1}";
            }

            char[] nb1 = number1.ToCharArray();
            char[] nb2 = number2.ToCharArray();
            string result = "";
            int rest = 0;
            for (int i = nb1.Length-1; i >=0 ; i--)
            {
                int chiffre1 = int.Parse(nb1[i].ToString());
                int chiffre2 = int.Parse(nb2[i].ToString());
                int addition = rest + chiffre1 + chiffre2;
                rest = addition / 10;
                addition = addition % 10;
                //if (addition > 10)
                //{
                //    rest = 1;
                //    addition = int.Parse(addition.ToString()[1].ToString());
                //}
                //else rest = 0;
                result = addition + result;
            }
            if (rest > 0) result = rest + result;

            Console.WriteLine(result);
        }
    }
}
