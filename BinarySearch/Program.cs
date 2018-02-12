using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select an integer from 1 to 10 to search for.");
            int searchInt = int.Parse(Console.ReadLine());

            int[] searchArray = new int[10];

            for (int i = 1; i <= searchArray.Length; i++)
            {
                searchArray[i-1] = i;
            }

            int searchResult = BinarySearchRecursive(searchArray, searchInt, 0, 10);
            Console.WriteLine("The integer " + searchInt + " was found at index " + searchResult + ".");
            //test to see if the index actually has that integer
            Console.WriteLine(searchArray[searchResult]);
            Console.ReadLine();
        }

        public static int BinarySearchLooping(int[] inputArray, int key)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return mid;
                }
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }

        public static int BinarySearchRecursive(int[] inputArray, int key, int min, int max)
        {
            if (min > max)
                return -1;
            else
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                    return mid;
                else if (key < inputArray[mid])
                    return BinarySearchRecursive(inputArray, key, min, mid - 1);
                else
                    return BinarySearchRecursive(inputArray, key, mid + 1, max);
            }
        }
    }
}
