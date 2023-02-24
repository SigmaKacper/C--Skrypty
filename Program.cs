using System;

namespace Lekcja6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 11);
            int user = 0;
            bool valid = false;
            int i = 0;
            bool[] array = new bool[10];

            Console.Title = "Zgadnij liczbe!";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Zgadnij liczbe od 1 do 10!\n");
            Console.ResetColor();

            do
            {
                do
                {
                    Console.Write("Podaj liczbe: ");
                    valid = int.TryParse(Console.ReadLine(), out user);
                    if (!valid)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Podaj prawidlowa liczbe!\n");
                        Console.ResetColor();
                    }
                }while(!valid);

                if(user < 1 || user > 10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Podaj liczbe z zakresu 1-10!\n");
                    Console.ResetColor();
                    continue;
                }

                if (array[user-1])
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Podano ta sama liczbe!\n");
                    Console.ResetColor();
                    continue;
                }
                else
                {
                    array[user-1] = true;
                }

                if(random < user)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Wylosowana liczba jest mniejsza od Twojej\n");
                    Console.ResetColor();
                }
                else if(random > user)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Wylosowana liczba jest wieksza od Twojej\n");
                    Console.ResetColor();
                }
                i++;
            } while (user != random);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Brawo!!! Trafiles liczbe w {i} strzalach\n");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
