using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter serach item");
            int searchItem = int.Parse(Console.ReadLine());

            int[] arr = {1, 2, 3, 4, 5, 5 , 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int result = BinarySearchDisplay(arr, searchItem);

            if (result < 0)
                Console.WriteLine("No match found");
            else 
                Console.WriteLine($"{searchItem} was found at {result}");
            
        }

        public static int BinarySearchDisplay(int[] arr, int searchItem)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (searchItem == arr[mid])
                {
                    return mid;
                }
                else if (searchItem < arr[mid])
                {
                    end = mid - 1;
                }
                else
                {
                     start = mid + 1;
                }
            }
            return -1;
        }
    }
}
