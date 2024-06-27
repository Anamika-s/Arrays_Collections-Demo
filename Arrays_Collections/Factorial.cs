using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Collections
{
    internal class FactorialDemo
    {
        static void Main()
        {
            Console.WriteLine(Factorial(5));
        }

        static int Factorial(int num)
        {
            if (num == 1) {  return 1; }
            
            else 
                
            return (num * Factorial(num - 1));
        }
    }
}
// 5 * Fact(4)    // 5 get stored in stack
// 5 * 4 * Fact(3) // 5 * 4 in stack
// 5* 4 * 3 *  Fact(2)  // 5 * 4 * 3 in stack

// 5* 4 * 3 * 2 *   Fact(1)  // 5 * 4 * 3 * 2 in stack

// after this they get popped frm the stack


