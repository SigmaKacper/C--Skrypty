using System;

namespace Lekcja2
{
    class Program
    {
        static void Main(string[] args)
        {
            // LICZBY CALKOWITE

            //Console.WriteLine($"MIN Byte: {byte.MinValue}, MAX Byte: {byte.MaxValue}");
            //Console.WriteLine($"MIN Short: {short.MinValue}, MAX Short : {short.MaxValue}");
            //Console.WriteLine($"MIN Int: {int.MinValue}, MAX Int: {int.MaxValue}");
            //Console.WriteLine($"MIN Long: {long.MinValue}, MAX Long: {long.MaxValue}");
            //Console.WriteLine();
            //Console.WriteLine($"MIN Byte: {byte.MinValue}, MAX Byte: {byte.MaxValue}");
            //Console.WriteLine($"MIN Short: {ushort.MinValue}, MAX Short : {ushort.MaxValue}");
            //Console.WriteLine($"MIN Int: {uint.MinValue}, MAX Int: {uint.MaxValue}");
            //Console.WriteLine($"MIN Long: {ulong.MinValue}, MAX Long: {ulong.MaxValue}");
            //Console.WriteLine();

            //sbyte varByte = -123;
            //Console.WriteLine($"Byte jako signed moze przybrac wartosc - z tego co wiem z CPP: {varByte}");

            //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\                                 
            // u - unsigned   s - signed                \\
            // ctrl + d   prefix i suffix                \\
            // konkatenacja to dodanie dwoch stringow     \\
            // ctrl + k, ctrl + c  // ctrl + u             ||
            // ctrl + k, ctrl + d                         //
            // lewy-alt + strzalka i zaznaczony tekst    //
            // '///' opis fukcji                        //             
            ////////////////////////////////////////////



            // ZMIENNO PRZECINKOWE

            //float varFloat = 2.137f;
            //double varDouble = 4.20d;
            //decimal varDecimal = 6.9m; // decimal opiera sie na wysokiej dokladnosci malych liczb

            //Console.WriteLine("{0:N20}", varFloat);
            //Console.WriteLine("{0:N20}", varDouble);
            //Console.WriteLine("{0:N20}", varDecimal);



            // ZMIENNE TEKSTOWE 

            //char varChar = 'A', varChar2 = 'B';
            //Console.WriteLine(varChar);
            //Console.WriteLine((int)varChar);
            //Console.WriteLine((int)varChar + (int)varChar2);
            //Console.WriteLine("No elo \"Dikko\" \nNowa Linia \\ Haha");

            //int kebab = 2;
            //Console.WriteLine(kebab.ToString() );



            // ZMIENNA LOGICZNA

            //bool czyPrawada = false;
            //Console.WriteLine(czyPrawada.ToString());
            //Console.WriteLine(czyPrawada); // to jest to samo bo z automatu sie przypisuje ta metoda


            // VAR czyli auto

            //var a = 2;
            //// a = 2.137  nie jest to zmienna dynamiczna dlatego nie mozna przypisywac rozncyh typow
            //Console.WriteLine(a + 2);

            //double d = 4.20;
            //Console.WriteLine(d + 1.1f);



            // KONWERSJA TYPOW - RZUTOWANIE
            /*
             * Rzutowanie niejawne polega na tym ze podczas konwersji nie zachodzi zadna strata danych
             * Rzutowanie jawne jest kiedy wiemy ze cos stracimy
             */

            //int varInt = 200000;

            //long varLong;
            //varLong = varInt; // Niejawne mozna napisac (long) ale program robi to sam

            //short varShort;
            //varShort = (short)varInt; // Jawne

            //float varFloat = 5.55f;
            //varLong = (long)varFloat; // Jawne, ale nie jest ono zaokraglane

            //string tekst = "123";
            ////varInt = (int)(object)tekst; nie mozliwa jest zmiana stringu na typ liczbowy

            

            // KONWERSJA TYPOW + PARSOWANIE

            //string tekst = Console.ReadLine();

            ////int varInt = int.Parse(tekst);
            ////Console.WriteLine(varInt);

            ////float varFloat = float.Parse(tekst.Replace('.', ','));
            ////Console.WriteLine(varFloat);

            //float varFloat;
            //bool success = float.TryParse(tekst.Replace('.', ','), out varFloat);
            //Console.WriteLine($"{varFloat} - {success}");

            //tekst = varFloat.ToString();
            ////tekst = true.ToString();
            //Console.WriteLine(tekst);
        }
    }
}
