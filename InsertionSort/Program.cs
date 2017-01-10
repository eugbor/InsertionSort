using System;
/// <summary>
/// Выполнить сортировку вставками целочисленного массива.
/// </summary>
namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = {5, 2, 4, 6, 1, 3};
            Show(intArray);
            RecursiveSort(intArray, 0, intArray.Length);
            Show(intArray);
            IterativeSort(intArray);
            Show(intArray);
            Console.ReadLine();
        }

        static void RecursiveSort(int[] array, int begIndex, int n)
        {
            if (begIndex >= n - 1)
                return;
            int i = begIndex + 1;
            int j = i;
            int b = array[i];
            j = Helper(array, j, b);
            array[j] = b;
            RecursiveSort(array, begIndex + 1, n);
        }

        static int Helper(int[] array, int j, int b)
        {
            if (j <= 0 || array[j - 1] <= b)
                return j;
            array[j] = array[j - 1];
            return Helper(array, j - 1, b);
        }

        static void IterativeSort(int[] intArray)
        {
            int temp, j;
            for (int i = 1; i < intArray.Length; i++)
            {
                temp = intArray[i];
                j = i - 1;

                while (j >= 0 && intArray[j] < temp)
                {
                    intArray[j + 1] = intArray[j];
                    j--;
                }

                intArray[j + 1] = temp;
            }
        }

        static void Show(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine();
        }
    }
}
