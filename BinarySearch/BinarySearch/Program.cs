
namespace BinarySearch
{
    using System;

    class Program
    {
        public static int SearchBinary(int[] numbers, int searchValue)
        {
            int midIndex;
            int leftIndex = 0;
            int rightIndex = numbers.Length - 1;
            
            while (leftIndex <= rightIndex)
            {
                midIndex = leftIndex + ((rightIndex - leftIndex) / 2);

                if (numbers[midIndex] == searchValue)
                {
                    return midIndex;
                }
                else
                {
                    if (numbers[midIndex] > searchValue)
                    {
                        rightIndex = midIndex - 1;
                    }
                    else
                    {
                        leftIndex = midIndex + 1;
                    }
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            Console.WriteLine("Enter the number you want to search from 1 to 13 : ");
            int searchNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Value found at index : " + SearchBinary(numbers, searchNumber));

            Console.ReadKey();
        }
    }
}
