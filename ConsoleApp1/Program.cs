using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // LEAP YEAR

            int chk_year;

            
            Console.Write("Check whether a given year is leap year or not:\n");
            
            Console.Write("Input an year : ");

            chk_year = Convert.ToInt32(Console.ReadLine());

            if ((chk_year % 400) == 0)
                Console.WriteLine("{0} is a leap year.\n", chk_year);
            else if ((chk_year % 100) == 0)
                Console.WriteLine("{0} is not a leap year.\n", chk_year);
            else if ((chk_year % 4) == 0)
                Console.WriteLine("{0} is a leap year.\n", chk_year);
            else
                Console.WriteLine("{0} is not a leap year.\n", chk_year);

        }

        private static void ex18()
        {

            // ex18 bbuble sort

            int[] number = { 89, 76, 45, 92, 67, 12, 99 };
            bool flag = true;
            int temp;
            int numLength = number.Length;


            for (int i = 1; (i <= (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (number[j + 1] > number[j])
                    {
                        temp = number[j];
                        number[j] = number[j + 1];
                        number[j + 1] = temp;
                        flag = true;
                    }
                }
            }


            foreach (int num in number)
            {
                Console.Write("\t {0}", num);
            }
            Console.Read();
        }

        private static void ex17()
        {
            // ex17 Sorting an Array using Selection Sort

            int[] arr = new int[10] { 56, 1, 99, 67, 89, 23, 44, 12, 78, 34 };
            int n = 10;
            Console.WriteLine("Selection sort");
            Console.Write("Initial array is: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            int temp, smallest;
            for (int i = 0; i < n - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = arr[smallest];
                arr[smallest] = arr[i];
                arr[i] = temp;
            }
            Console.WriteLine();
            Console.Write("Sorted array is: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}





