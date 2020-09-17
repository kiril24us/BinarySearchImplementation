using System;

namespace BinarySearchImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 5, 10, 20, 30, 37, 45 };
            int number = 45;
            int index = BinarySearch(numbers, number);
            if (index == -1)
            {
                Console.WriteLine("No such number in the array!");
            }
            else
            {
                Console.WriteLine($"The number is found on index {index}");
            }
        }

        private static int BinarySearch(int[] inputArray, int number)
        {
            int start = 0;
            int end = inputArray.Length;
            for (int i = start; i < end; i++)
            {
                int middle = (end - start) / 2;
                int middleItem = inputArray[start + middle];
                if (middleItem == number)
                {
                    return start + middle;
                }
                if (middleItem < number)
                {
                    start += middle;
                }
                else
                {
                    end -= middle;
                }
            }
            return -1;
        }
    }
}
