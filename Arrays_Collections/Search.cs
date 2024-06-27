using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Collections
{
    internal class Search
    {
        static int[] num = [1, 4, 7, 10, 12, 13, 80, 19];
        static void Main()
        {
            Console.WriteLine("enter number to search");
            int x = byte.Parse(Console.ReadLine());
            Console.WriteLine(LinearSearch(x));
            Array.Sort(num);
            Console.WriteLine(BinarySearchF(x));

        }

        static bool LinearSearch(int x)
        {
            bool flag = false;
            foreach (int i in num)
            {
                if (i == x)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }

        static bool BinarySearchF(int x)
        {
            bool flag = false;
            int low, high, mid;
            low = 0;
            high = num.Length - 1;
            while (low <= high)
            {
                mid = (low + high) / 2;
                if (num[mid] == x)
                {
                    flag = true;
                    break;
                }
                else if (x > num[mid])
                    low = mid + 1;
                else if (x < num[mid])
                    high = mid - 1;
                mid = (low + high) / 2;
            }
            return flag;
        }
    }
}