using System;
using System.Linq;

namespace BubbleSort
{
    class Program
    {
        public static void BubbleSort(int[] arr)
        {
            int temp = 0;

            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1 - write; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 numbers to sort : ");

            int[] arr = new int[3];

            for (int i = 0; i < 3; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());

            BubbleSort(arr);

            for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + " ");

            Console.ReadKey();
        }
    }
}
