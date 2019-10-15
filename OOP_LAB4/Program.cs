using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB4
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<int> stack = new Stack<int>(5);
            stack = stack + 5;
            stack = stack + 8;
            Stack<int> stack2 = new Stack<int>(5);
            stack2 = stack2 + 2;
            stack2 = stack2 + 7;
            //stack2 = stack2 > stack;
            Console.WriteLine(stack.Top());

            Console.WriteLine(StatisticOperation.Sum(stack));
            Console.WriteLine(stack.Top());
        }
    }
}
