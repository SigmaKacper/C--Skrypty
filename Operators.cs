using System;

namespace Lekcja3
{
    class Program
    {
        static void Main(string[] args)
        {
            // OPERATORY ARYTMETYCZNE

            //Console.Write("Podaj a: ");
            //int a = int.Parse(Console.ReadLine()); 
            //Console.Write("Podaj b: ");
            //int b = int.Parse(Console.ReadLine());

            ////int wynik = a + b;
            //Console.WriteLine($"{a} + {b} = {a + b}");
            //Console.WriteLine($"{a} - {b} = {a - b}");
            //Console.WriteLine($"{a} * {b} = {a * b}");
            //Console.WriteLine($"{a} / {b} = {(float)a / (float)b}");
            //Console.WriteLine($"{a} % {b} = {a % b}");

            //Console.WriteLine("----------");
            //Console.WriteLine((a + a) * 6);

            //Console.WriteLine("----------");
            //Console.WriteLine(Math.Pow(a, b));
            //Console.WriteLine(Math.Sqrt(a)); // pierwiastek 2 stopnia
            //Console.WriteLine(Math.Pow(a, 1d / 3)); // pierwiastek 3 stopnia
            //Console.WriteLine(Math.Sqrt(Math.Sqrt(a))); // pierwiastek 4 stopnia



            // SKORCONE OPERATORY ARYTMETYCZNE

            //int a = 5;
            //// a = a + 10
            //a += 10; // 15 (DRY - Dont repeat yourself)
            //a -= 3; // 12
            //a *= 2; // 24
            //a /= 6; // 4
            //a %= 3; // 1
            //Console.WriteLine(a);



            // Inkrementacja i Dekrementacja

            //int a = 5;
            //int b = 5;

            //Console.WriteLine(a++); // wyswietli 5 zmieni na 6
            //Console.WriteLine(++b); // wyswietli 6

            //// pre inktrementacja ++a zajdzie ona przed dzialaniem
            //// post inkrementacja a++ zostanie dodana po dzialaniu
            //// dekrementacja -||-
            //a = 5;
            //b = a++; // b bedzie zawierac 5, lecz a 6 poniewaz inkrementacja wykona sie po przypisaniu
            //Console.WriteLine(b);
            //// !!! UWAGA - Nawet jezeli wypiszesz to na ekranie to ta zmiana zachodzi
            //// poniewaz to tak jakbys uzyl CW(a = a + 1) rozumiesz ? !!!!!!!!!!!!!!!!!



            // OPERATORY POROWNANIA

            //Console.Write("podaj a: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("podaj b: ");
            //int b = int.Parse(Console.ReadLine());

            ////bool wynik = a == b; to dzial fr
            //Console.WriteLine($"{a} == {b} = {a == b}");
            //Console.WriteLine($"{a} != {b} = {a != b}");
            //Console.WriteLine($"{a} > {b} = {a > b}");
            //Console.WriteLine($"{a} < {b} = {a < b}");
            //Console.WriteLine($"{a} <= {b} = {a <= b}");
            //Console.WriteLine($"{a} >= {b} = {a >= b}");



            // OPERATORY LOGICZNE

            //bool wynik = true || false; // OR
            //Console.WriteLine(wynik);


            //wynik = true && false; // AND
            //Console.WriteLine(wynik);

            //wynik = !true; // NEGACJA
            //Console.WriteLine(wynik);

            //Console.WriteLine(true || false && false); // && AND ma pierwszenstwo
            //Console.WriteLine( (true || false) && false);

        }
    }
}
