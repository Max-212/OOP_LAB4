using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB4
{
    static class StatisticOperation
    {
        public static int Sum(Stack<int> stack)
        {
            Stack<int> stack1 = (Stack<int>)stack.Clone();
            int result = 0;
            int n = stack1.Count;
            for (int i = 0; i < n; i++)
            {
                result += stack1.Top();
                stack1--;
            }
            return result;
        }

        public static int quantity(this Stack<int> stack)
        {
            return stack.Count;
        }

        public static int quantity(this Stack<string> stack)
        {
            return stack.Count;
        }
    }
}
