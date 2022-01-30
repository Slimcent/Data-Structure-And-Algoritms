using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    internal class Program
    {
        public static int LinearSearchDisplay(int[] arr, int searchItem)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == searchItem)
                    return i;
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[15] {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};

            Console.WriteLine("Enter serach Item");
            int searchItem = int.Parse(Console.ReadLine());

            int result = LinearSearchDisplay(arr, searchItem);
            if (result >= 0)
                Console.WriteLine($"{searchItem} was found on position of {result}");
            else
                Console.WriteLine("No item was found");
        }
    }
}
