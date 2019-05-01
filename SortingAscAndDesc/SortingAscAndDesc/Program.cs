using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAscAndDesc
{
    class Program
    {
        public static void BubbleSortAsc(int[] arr)
        {
            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        public static void BubbleSortDesc(int[] arr)
        {
            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 3, 1, 6, 5, 4 };
            int[] arr2 = new int[arr.Length];
            int[] arr3 = new int[arr.Length];

            int[] newArrEven = new int[arr.Length];
            int[] newArrOdd = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] % 2) == 0)
                {
                    arr2[i] = arr[i];
                }
                else
                {
                    arr3[i] = arr[i];
                }
                
            }
            BubbleSortAsc(arr2);
            BubbleSortDesc(arr3);
            Console.WriteLine(string.Join(" ", arr2));
            Console.WriteLine(string.Join(" ", arr3));



            Console.Read();
        }
    }
}
