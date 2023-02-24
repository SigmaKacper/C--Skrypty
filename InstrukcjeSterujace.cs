using System;

namespace Lekcja4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2 lekcje jednoczesnie
            // INSTRUKCJE WARUNKOWE - IF
            // INSTRUKCJE WARUNKOWE - ELSE

            //Console.WriteLine("Ile masz lat :");
            //int wiek = int.Parse(Console.ReadLine());

            //// robie ten kurs pod siebie wiec wypad z mojego git'a (zartuje jak cos)
            //if (wiek >= 18)
            //    Console.WriteLine("Zapraszamy");
            //else 
            //{
            //    Console.WriteLine("Nie masz 18 lat!");
            //    Console.WriteLine("Przykro nam.");
            //}



            // INSTRUKCJE WARUNKOWE - ELSE IF

            //Console.WriteLine("Podaj liczbe: ");
            //int num = int.Parse(Console.ReadLine());

            //if(num > 0)
            //{
            //    Console.WriteLine("Liczba jest WIEKSZA od 0");
            //}
            //else if(num == 0)
            //{
            //    Console.WriteLine("Liczba JEST rowna 0");
            //}
            //else if(num < 0) // lub else
            //{
            //    Console.WriteLine("Liczba jest MNIEJSZSA od 0");
            //}



            // SKROCONE WYRAZENIA WARUNKOWE

            //Console.Write("Podaj liczbe: ");
            //int a = int.Parse(Console.ReadLine());

            //string wynik = a % 2 == 0 ? "Parzysta" : "Nieparzysta";
            //Console.WriteLine(wynik);



            // INSTRUKCJA - SWITCH

            //Console.Write("Podaj dzien tygodnia: ");
            //int a = int.Parse(Console.ReadLine());

            //switch (a)  // mozna uzywac wszystykich typow
            //{
            //    case 1: // ==  
            //        Console.WriteLine("Poniedziałek");
            //        break;
            //    case 2:
            //        Console.WriteLine("Wtorek");
            //        break;
            //    case 3:
            //        Console.WriteLine("Środa");
            //        break;
            //    case 4:
            //        Console.WriteLine("Czwartek");
            //        break;
            //    case 5:
            //        Console.WriteLine("Piątek");
            //        break;
            //    case 6:
            //    case 7:
            //        Console.WriteLine("Weekend");
            //        break;
            //    default: 
            //        Console.WriteLine("Nie ma takiego dnia");
            //        break;
            //}



            // PĘTLA - WHILE               

            //Console.WriteLine("Podaj liczbe: ");
            //int a = int.Parse(Console.ReadLine());
            //int i = 1;

            //while(i <= a)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}



            // PĘTLA - DO WHILE

            //Console.WriteLine("Podaj liczbe: ");
            //int a = int.Parse(Console.ReadLine());
            //int i = 1;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i <= a);



            // PĘTLA - FOR

            //Console.WriteLine("Podaj liczbe: ");
            //int a = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= a; i++)
            //{
            //    Console.WriteLine(i);
            //}



            // PETLA FOREACH

            //Console.WriteLine("Podaj liczbe: ");
            //string text = Console.ReadLine();

            //foreach (var item in text) // string jest tablica typu char
            //{
            //    Console.WriteLine(item);
            //}


            // CONTINUE I BREAK



            // GOTO  
            // etykieta to mniedzy innymi case w switchu

            //    int i = 0;
            //hello:
            //    Console.WriteLine("Hello");
            //    i++;

            //    if (i < 10)
            //        goto hello;



            // SREDNIA ARYTMETYCZNA - PRAKTYKA
            //float a;
            //float sum = 0;
            //int i = 0;

            //do
            //{
            //    Console.Write("Podaj liczbe: ");
            //    a = float.Parse(Console.ReadLine());
            //    sum += a;
            //    if(a != 0)
            //        i++;
            //}while(a != 0);

            //Console.WriteLine($"Srednia to: {Math.Round(sum/i, 2)}");

        }
    }
}
