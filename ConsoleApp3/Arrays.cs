using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
/*
    class Arrays
    {
        static void Main(String[] args)
        {
            // Length property - single dimension array
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine(numbers.Length);

            // 2 dimensional array
            //int[,] a = new int[2, 3]{ { 2,4,6}, { 3,6,9} };
            int[,] a;
            a = new int[2, 3] { { 2, 4, 6 }, { 3, 6, 9 } };

            // accessing the array
            Console.WriteLine(a[0, 0]);

            // Rank property
            Console.WriteLine("The rank of the array is " + a.Rank);           

            // jagged arrays
            int[][] jA = new int[3][];

            jA[0] = new int[5] { 1, 2, 3, 4, 5 };
            jA[1] = new int[4] { 2, 4, 6, 8 };
            jA[2] = new int[2] { 1, 2};

            Console.WriteLine(jA [0][1]); //will print 2

            Console.WriteLine(jA[1][3]); //will print 8

            Console.WriteLine(jA[2][1]); //will print 2

            Console.WriteLine("length of i is " + (jA.Length - 1));
            //Display the elements of an array
            for (int i =0; i<jA.Length; i++)
            {
                for(int j=0;j<jA[i].Length;j++)
                {
                    Console.WriteLine("The value of ja[" +i + "][" + j+ "] is " + jA[i][j]);

                }
            }


            // foreach loop
            int[] test = {1,2,3,4,5,6,7,8,9,10 };

            foreach(int i in test)
            {
                Console.WriteLine(i);
            }

            // passing array as arguments example
            string[] weekdays = {"Sun", "Mon", "Tue", "Wed","Thu", "Fri","Sat" };
            DisplayArray(weekdays);

            ChangeArray(weekdays);
            Console.WriteLine("After the call to ChangeArray method");
            DisplayArray(weekdays);

            ChangeArrayElements(weekdays);
            Console.WriteLine("After the call to ChangeArrayElements method");
            DisplayArray(weekdays);


            Console.ReadLine();


        }

        static void DisplayArray(string[] arr) => Console.WriteLine(String.Join(" ", arr));

        static void ChangeArray(string[] arr) => Array.Reverse(arr);

        static void ChangeArrayElements(string[] arr)
        {
            arr[0] = "Changed";
            arr[1] = "Changed";
            arr[2] = "Changed";
        }
    }
*/
}
