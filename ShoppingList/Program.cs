using System;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
public class main()
{
    public static void Main()
    {
        List<string> shoppingList = new List<string>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nwelcome to Shopping List");
            Console.WriteLine("enter 1 to add something to list");
            Console.WriteLine("enter 2 to remove something on list");
            Console.WriteLine("enter 3 to show list");
            Console.WriteLine("enter 4 to exit");
            Console.WriteLine("i'm waiting to your choice");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("please enter the name of item you wanna add");
                    string newItem = Console.ReadLine();
                    shoppingList.Add(newItem);
                    Console.WriteLine("your item added");
                    break;
                case "2":
                    Console.WriteLine("please enter the name of item you wanna remove");
                    string delItem = Console.ReadLine();
                    if (shoppingList.Remove(delItem))
                        Console.WriteLine("your item removed");
                    else
                        Console.WriteLine("your item not found");
                    break;
                case "3":
                    Console.WriteLine("your shopping list is :");
                    if (shoppingList.Count == 0)
                        Console.WriteLine("empty list");
                    else
                        foreach (string item in shoppingList)
                            Console.WriteLine($"-{item}");
                    break;
                case "4":
                    running = false;
                    Console.WriteLine("bye");
                    break;
                default:
                    Console.WriteLine("choice not found");
                    break;

            }
        }
    }
}