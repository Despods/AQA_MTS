using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DelegateHomeWork
{
    internal class Task3Delegate
    {
        public delegate int[] Sorting(int[] arrays);
        
        public void Run()
        {
            int[] array = new int[10];

            Console.WriteLine("Исходный массив");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(10);
            }

            Print(array);

            Console.WriteLine();
            Console.WriteLine("Сортировка пузырьком");
            Sorting sortedBuble = SortingBy(TypeSort.BubleSort);
            Print(sortedBuble(array));

            Console.WriteLine();
            Console.WriteLine("Сортировка шейкером");
            Sorting sortedShaker = SortingBy(TypeSort.ShakerSort);
            Print(sortedShaker(array));
        }

        private Sorting SortingBy(TypeSort sortingType)
        {
            switch (sortingType)
            {
                case TypeSort.BubleSort:
                    return BubleSorting;
                    default: return ShakerSorting;
            }
        }

        private int[] BubleSorting(int[] arrays)
        {
            for (int i = 0; i < arrays.Length; i++)
                for (int j = 0; j < arrays.Length - 1; j++)
                    if (arrays[j] > arrays[j + 1])
                    {
                        int t = arrays[j + 1];
                        arrays[j + 1] = arrays[j];
                        arrays[j] = t;
                    }
            return arrays;
        }

        private int[] ShakerSorting(int[] arrays)
        {
            for (int i = 0; i < arrays.Length / 2; i++)
            {
                var swapFlag = false;

                for (var j = i; j < arrays.Length - i - 1; j++)
                {
                    if (arrays[j] > arrays[j + 1])
                    {
                        var temp = arrays[j];
                        arrays[j] = arrays[j + 1];
                        arrays[j + 1] = temp;
                        swapFlag = true;
                    }
                }

                for (var j = arrays.Length - 2 - i; j > i; j--)
                {
                    if (arrays[j - 1] > arrays[j])
                    {
                        var temp = arrays[j - 1];
                        arrays[j - 1] = arrays[j];
                        arrays[j] = temp;
                        swapFlag = true;
                    }
                }

                if (!swapFlag)
                {
                    break;
                }
            }
            return arrays;
        }
        public static void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}  ");
            }
        }
    }
}
