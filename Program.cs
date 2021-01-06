using System;

namespace _11_сортировка_пузырьком
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 6, 7, 19, 13, 15 };
            //int n = 10; // искомое число 



            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine(" ");

            Console.WriteLine(bin_search(array));
        }

        static string bin_search(int[] my_array)
        {

            int b;
            int min = 0;
            int max = my_array.Length - 1;

            for (int i = 0; i < my_array.Length; i++)
            {
                for (int j = 0; j < my_array.Length - 1 - i; j++)
                {
                    //Если элемент массива с индексом j больше следующего за ним элемента
                    if (my_array[j] > my_array[j + 1])
                    {
                        // Меняем местами элемент массива с индексом j и следующий за ним
                        b = my_array[j];
                        my_array[j] = my_array[j + 1];
                        my_array[j + 1] = b;

                    }
                }
            }

            for (int i = 0; i < my_array.Length; i++)
            {
                Console.WriteLine(my_array[i]);
            }

            return "    ";

        }
    }
}
