using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Collections
{
    internal class GenericCollectionDemo
    {
        static void Main()
        {

            // ArrayList
            List<int> list = new List<int>(capacity:10);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(1);
            list.Add(2);
            list.Add(3); list.Add(1);
            list.Add(2);
            list.Add(3); list.Add(1);
            list.Add(2);
            list.Add(3); list.Add(1);
            list.Add(2);
            list.Add(3); list.Add(1);
            list.Add(2);
            list.Add(3); list.Add(1);
            list.Add(2);
            list.Add(3); list.Add(1);
            list.Add(2);
            list.Add(3); list.Add(1);
            list.Add(2);
            list.Add(3); list.Add(1);
            list.Add(2);
            list.Add(3); list.Add(1);
            list.Add(2);
            list.Add(3);
            Console.WriteLine("list.Capacity " + list.Capacity);
            Console.WriteLine("list.Count " +  list.Count);

            Console.WriteLine("elements are");
            foreach (int i in list)
                Console.WriteLine(i);

            // Stack
            Stack<float> stack = new Stack<float>();
            stack.Push(10.0f);

            // Queue
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);

            // HashTable
            Dictionary<int, string> records = new Dictionary<int, string>();

            records[1] = "New Delhi";
        }
    }
}
