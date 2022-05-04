using System;

namespace Module_1
{
    internal class Program
    {
        private static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] main_Array = new int[n];
            int[] first_Number_Array = new int[n];
            int[] second_Number_Array = new int[n];
            char[] first_Letter_Array = new char[n];
            char[] second_Letter_Array = new char[n];
            int first_amount = 0;
            int second_amount = 0;
            string str = @" AbcDEfgHIJklmnopqrstuvwxyz";

            for (int i = 0; i < n; i++)
            {
                main_Array[i] = new Random().Next(1, 26);
                if (main_Array[i] % 2 != 0)
                {
                    first_Number_Array[i] = main_Array[i];
                }
                else
                {
                    second_Number_Array[i] = main_Array[i];
                }
            }

            Array.Sort(first_Number_Array);
            Array.Reverse(first_Number_Array);
            Array.Sort(second_Number_Array);
            Array.Reverse(second_Number_Array);
            for (int i = 0; i < n; i++)
            {
                first_Letter_Array[i] = str[first_Number_Array[i]];
                if ((first_Letter_Array[i] == 'A') || (first_Letter_Array[i] == 'E') || (first_Letter_Array[i] == 'I'))
                {
                    first_amount++;
                }
            }

            for (int i = 0; i < n; i++)
            {
                second_Letter_Array[i] = str[second_Number_Array[i]];
                if ((second_Letter_Array[i] == 'D') || (second_Letter_Array[i] == 'H') || (second_Letter_Array[i] == 'J'))
                {
                    second_amount++;
                }
            }

            Console.WriteLine(str.Length);
            Console.WriteLine("\nМассив с нечётными буквами:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(first_Letter_Array[i] + " ");
            }

            Console.WriteLine("\nМассив с чётными буквами:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(second_Letter_Array[i] + " ");
            }

            if (first_amount > second_amount)
            {
                Console.WriteLine("\nНечётных заглавных букв больше");
            }
            else if (first_amount < second_amount)
            {
                Console.WriteLine("\nЧётных заглавных букв больше");
            }
            else
            {
                Console.WriteLine("\nЗаглавных букв одинаковое количество");
            }
        }
    }
}
