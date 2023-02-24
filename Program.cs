// 1.0          17-02-2023
// 1.1          19-02-2023


using System;
using System.Security.Authentication.ExtendedProtection;

namespace Lekcja1
{
    class Program
    {
        /// <summary>
        /// Zwraca wszystkie wazne informacje na temat
        /// zamowienia kebabowego w Mikstacie
        /// </summary>
        /// <param name="ilosc">Ilosc kebabow</param>
        /// <param name="wielkosc">Wielkosc kebaba jako napis</param>
        /// <param name="cena">Cena kebab za sztuke</param>
        static void kebab(int ilosc, string wielkosc, decimal cena)
        {
            Console.WriteLine("Hol cena kebaba to: {0} \nIlosc kebabow: {1}\nOjc przypadkiem ujebalo nam sie 200 ton miesa \nZatem zaplacisz za {2} kebaba lacznie: {3:N5}", cena, ilosc, wielkosc, cena * ilosc);
        }

        static void Main(string[] args)
        {
            // Ilosc
            Console.Write("Ile kebabow wariacie: ");
            string stringIlosc = Console.ReadLine();
            int ilosc = int.Parse(stringIlosc.Replace('.', ','));

            // Rozmiar
            Console.Write("Jaki rozmiar kebabow: ");
            string wielkosc = Console.ReadLine();

            // Cena
            Console.Write("Masz dzisiaj farta to ty podajesz cene: ");
            string stringCena = Console.ReadLine();
            decimal cena = decimal.Parse(stringCena.Replace('.', ','));

            kebab(ilosc, wielkosc, cena);
        }

    }
}

/*
  1234567890-=qwertyuiop[]\asdfghjkl;'zxcvbnm,./1234567890-=qwertyuiop[]\asdfghjkl;'zxcvbnm,./1234567890-=qwertyuiop[]\asdfghjkl;'zxcvbnm,./1234567890-=qwertyuiop[]\asdfghjkl;'zxcvbnm,./

                           |------
                           |     *      00000         \      Metoda ReadLine                                        
                   |-------      *      0 X 0          \                 nie moze
                   |             *      00000           \                       przyjmowac int'ow
                   |             *              /        |                               dlatego z automatu uzyje
                   |-------      *              \        |                                         przez mnie ustalonej ceny
                           |     *      00000           /
                           |     *      0 X 0          /                                                   // "Wiem ze to rozpierdala ( CHODZILO MI O JEBANY RYSUNEK TEKSTOWY )"
                           |------      00000         /                                                    //  ~ Kacper Wojtkowski
                                                                    
                                                                                                           // wersja poprawkowa 1.1 zostala wydana 19.02.2023 
  1234567890-=qwertyuiop[]\asdfghjkl;'zxcvbnm,./1234567890-=qwertyuiop[]\asdfghjkl;'zxcvbnm,./1234567890-=qwertyuiop[]\asdfghjkl;'zxcvbnm,./1234567890-=qwertyuiop[]\asdfghjkl;'zxcvbnm,./
 */