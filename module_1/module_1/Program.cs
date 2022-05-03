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
                switch (first_Number_Array[i])
                {
                    case 1:
                        first_Letter_Array[i] = 'A';
                        first_amount++;
                        break;
                    case 3:
                        first_Letter_Array[i] = 'c';
                        break;
                    case 5:
                        first_Letter_Array[i] = 'E';
                        first_amount++;
                        break;
                    case 7:
                        first_Letter_Array[i] = 'g';
                        break;
                    case 9:
                        first_Letter_Array[i] = 'I';
                        first_amount++;
                        break;
                    case 11:
                        first_Letter_Array[i] = 'k';
                        break;
                    case 13:
                        first_Letter_Array[i] = 'm';
                        break;
                    case 15:
                        first_Letter_Array[i] = 'o';
                        break;
                    case 17:
                        first_Letter_Array[i] = 'q';
                        break;
                    case 19:
                        first_Letter_Array[i] = 's';
                        break;
                    case 21:
                        first_Letter_Array[i] = 'u';
                        break;
                    case 23:
                        first_Letter_Array[i] = 'w';
                        break;
                    case 25:
                        first_Letter_Array[i] = 'y';
                        break;
                }
            }

            for (int i = 0; i < n; i++)
            {
                switch (second_Number_Array[i])
                {
                    case 2:
                        second_Letter_Array[i] = 'b';
                        break;
                    case 4:
                        second_Letter_Array[i] = 'D';
                        second_amount++;
                        break;
                    case 6:
                        second_Letter_Array[i] = 'f';
                        break;
                    case 8:
                        second_Letter_Array[i] = 'H';
                        second_amount++;
                        break;
                    case 10:
                        second_Letter_Array[i] = 'J';
                        second_amount++;
                        break;
                    case 12:
                        second_Letter_Array[i] = 'l';
                        break;
                    case 14:
                        second_Letter_Array[i] = 'n';
                        break;
                    case 16:
                        second_Letter_Array[i] = 'p';
                        break;
                    case 18:
                        second_Letter_Array[i] = 'r';
                        break;
                    case 20:
                        second_Letter_Array[i] = 't';
                        break;
                    case 22:
                        second_Letter_Array[i] = 'v';
                        break;
                    case 24:
                        second_Letter_Array[i] = 'x';
                        break;
                    case 26:
                        second_Letter_Array[i] = 'z';
                        break;
                }
            }

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
