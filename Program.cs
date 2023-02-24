using System;
using System.ComponentModel;

namespace Lekcja5
{
    class Program{
        static void Main(string[] args)
        {
            // TABLICE WIELKOWYMIAROWE

            //int[] array = new int[5];
            //array[0] = 1;
            //array[1] = 2;
            //array[2] = 3;
            //array[3] = 4;
            ////array[4] = 0; nie uzyte sa zerowane

            //Console.WriteLine("Length: {0}", array.Length);
            //for(int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

            //Console.WriteLine();

            //char[] array2 = { 'h', 'e', 'l', 'l', 'o' };

            //foreach(char item in array2)
            //{
            //    Console.WriteLine(item);
            //}



            // TABLICE WIELOWYMIAROWE (2 wymiarowe - prostokatne)

            //int[,] arrey2D = new int[5, 10];
            //arrey2D[0, 0] = 1;
            //arrey2D[1, 2] = 9;

            //Console.WriteLine(arrey2D[0, 0]);
            //Console.WriteLine(arrey2D[1, 2]);
            //Console.WriteLine("\nWymiary:");
            //Console.WriteLine(arrey2D.Length);

            //Console.WriteLine(arrey2D.GetLength(0));
            //Console.WriteLine(arrey2D.GetLength(1));

            //Console.WriteLine("\narray 2D");
            //for(int i = 0; i < arrey2D.GetLength(0); i++)
            //{
            //    for(int j = 0; j < arrey2D.GetLength(1); j++)
            //    {
            //        Console.Write(arrey2D[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("\narray3D: ");
            //int[,,] array3D = new int[5, 5, 5];
            //array3D[0, 1, 0] = 1;
            //Console.WriteLine(array3D[0 ,1, 0]);

            //Console.WriteLine("\nText Array: ");
            //string[,] arrayText = { { "Hello", "World" }, { "Witaj", "Świecie" } };

            //Console.WriteLine(arrayText[0, 0] + " " + arrayText[0, 1]);
            //Console.WriteLine(arrayText[1, 0] + " " + arrayText[1, 1]);

            //foreach(var item in arrayText)
            //{
            //    Console.WriteLine(item);
            //}



            // TABLICA TABLIC

            //int[][] array = new int[3][];
            //array[0] = new int[5];
            //array[1] = new int[3];
            //array[2] = new int[7]; // tablice postrzępione
 
            //array[0][1] = 1;
            //array[2][6] = 9;

            //Console.WriteLine(array[0][1]);
            //Console.WriteLine(array[2][6]);

            //Console.WriteLine("\nFor:");

            //for(int i = 0; i < array.Length; i++)
            //{
            //    for(int j = 0; j < array[i].Length; j++)
            //    {
            //        Console.Write(array[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //foreach(int[] array2 in array)
            //{
            //    foreach(int item in array2)
            //    {
            //        Console.Write(item + " ");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
 