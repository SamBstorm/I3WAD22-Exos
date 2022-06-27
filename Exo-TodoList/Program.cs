using System;
using System.Collections.Generic;

namespace Exo_TodoList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> todolist = new List<string>();
            string userChoice;
            do
            {
                int count = 1;
                foreach (string item in todolist)
                {
                    Console.WriteLine($"{count}) {item}");
                    count++;
                }
                do
                {
                    Console.WriteLine("Pour ajouter une tâche appuyer sur 'A'.");
                    if (todolist.Count >0) Console.WriteLine("Pour supprimer une tâche appuyer sur 'S'.");
                    Console.WriteLine("Pour quitter appuyer sur 'Q'.");
                    userChoice = Console.ReadLine();
                } while (userChoice != "A" && userChoice != "Q" && (userChoice!="S" || todolist.Count <= 0));

                switch (userChoice)
                {
                    case "A":   Console.WriteLine("Veuillez indiquer la tâche à accomplir :");
                                string task = Console.ReadLine();
                                if (!todolist.Contains(task))
                                {
                                    todolist.Add(task);
                                }
                        break;
                    case "S":   int indexToRemove;
                                do
                                {
                                    Console.WriteLine("Veuillez identifier une tâche à supprimer :");
                                } while (!int.TryParse(Console.ReadLine(), out indexToRemove) || indexToRemove <1 || indexToRemove > todolist.Count);
                                todolist.Remove(todolist[indexToRemove-1]);
                        break;
                    case "Q":   Console.WriteLine("Au revoir! merci d'avoir utilisé ToDoList-3000!");
                        break;
                }
                Console.Clear();
            } while (userChoice != "Q");
        }
    }
}
