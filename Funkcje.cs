using System;
using System.ComponentModel;

namespace Lekcja7
{
    class Program
    {
        // WARTOSCI DOMYSLNE
        // ARGUMENTY NAZWANE

        //static void Main(string[] args)
        //{
        //    Hello("Hello User", 1); 
        //    Hello(times: 3, text: "KMS");
        //    Hello("Hi");
        //    Hello();
        //}

        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        Console.WriteLine(text);
        //    }
        //}



        // ZWARACANIE WARTOSCI

        //static void Main(string[] args)
        //{
        //    int res = Add(5, 10);
        //    Console.WriteLine(res);
        //}

        //static int Add(int a, int b)
        //{
        //    int sum = a + b;
        //    return sum;
        //}



        // PRZECIAZANIE NAZW FUNCKJI 

        //static void Main(string[] args)
        //{
        //    Add(5);
        //    Add(7.5d);
        //    int decymalnie = Add(8.5m); 
        //    Add(3, 9);
        //    Add(1, 10, 100);

        //    Console.WriteLine(decymalnie);
        //}

        //static void Add(int a) 
        //{
        //    Console.WriteLine(++a); 
        //}

        //static void Add(int a, int b = 1)
        //{
        //    Console.WriteLine(a + b );
        //}

        //static int Add(int a)
        //{
        //    return ++a; 
        //}

        //static int Add(decimal a) 
        //{
        //    return (int)++a;
        //}

        //static void Add(double a)
        //{
        //    Console.WriteLine(a + 1.5);
        //}
    
        //static void Add(int a, int b)
        //{
        //    Console.WriteLine(a + b);
        //}

        //static void Add(int a, int b, int c)
        //{
        //    Console.WriteLine(a + b + c);
        //}



        // PARAMS 

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("{0} {1} {2}", "Hello", "World", "!!!");

        //    Print("{0} {1} {2} {3}", "Hello", "World", "!!!", "2+3");
        //}

        //static void Print(string text, params string[] arg) 
        //{
        //    for(int i = 0; i < arg.Length; i++)
        //    {
        //        text = text.Replace("{" + i + "}", arg[i]);
        //    }
        //    Console.WriteLine(text);
        //}



        // REKURENCJA 
        // ale pojebane FR
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("n = 0: " + Silnia(0));
        //    Console.WriteLine("n = 1: " + Silnia(1));
        //    Console.WriteLine("n = 2: " + Silnia(2));
        //    Console.WriteLine("n = 3: " + Silnia(3));
        //    Console.WriteLine("n = 4: " + Silnia(4));
        //    Console.WriteLine("n = 5: " + Silnia(5));
        //    Console.WriteLine("n = 5: " + Silnia(-5)); // Jest to
        //    // zabezpiecznie przed wyjatkiem pomimo ze nie jest to
        //    // logiczne matematycznie 
        //}

        //static int Silnia(int n)
        //{
        //    if (n <= 0) // przypadek domyslny 5

        //    {
        //        return 1;
        //    }
        //    else
        //    {
        //        return n * Silnia(n - 1);
        //    }
        //}



        // REF i OUT

        static void Main(string[] args)
        {
            int a;
            int[] array = new int[1];
            array[0] = 1;
            Test(out a, ref array);
            Console.WriteLine($"a = {a}\narray = {array[0]}");

            int c; // = 1 zbedne
            bool check = int.TryParse("abc", out c);
            Console.WriteLine(c); 

        }
      
        static void Test(out int a, ref int[] array)
        {
            // return;
            a = 9; 

            //array = new int[1];
            array[0] = 9;
        }
    }
}

/* WSZYSTKIE ANEGDOTY
 *  Sygnatura funkcji (nawiasy) -> (tutaj sa argumenty)
 * 
 *   static (typ) ... przeciazenie nie jest mozliwe bo typ 
 *   zwracy nie robi roznicy wazna jest ilosc argumentow i ich typ
 *   
 *   wartosci domyslne musza byc napisane na koncu funkcji 
 *   
 *   params dziala na zasadzie ze indeksuje dane
 *   
 *   typ prymitywny typ wartosciowy
 *   typ zlozony jak i kolecja (typ referencyjny)
 *   wskazuja na tem sam adres
 *
 *   referencja musi byc w 2 miejscach 
 *   przed wyslaniem musi byc inicjalizacja
 *
 *  out rozni sie od ref ze dopuszcza nie zainicjalizowana zmienna
 *  aleeee musi ona byc przypisana w srodku funkcji
 *  
 *  nie mozemy zwaracac jezeli uzywamy out i wczesniej nie przypiszemy 
 *  do zmiennych wartosc
 *  out uzywa sie miedzy inny ze zastepuje ono return jezeli chcemy zworcic
 *  wiecej niz 1 wartosc 
 */
