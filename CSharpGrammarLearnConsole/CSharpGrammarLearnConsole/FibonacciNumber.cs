using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpGrammarLearnConsole
{
    internal static class FibonacciNumber
    {
        internal static int GetFibonacciNumber(int n)
        {
            if (n > 2)
            {
                //递归：获得n-1和n-2的数
                return GetFibonacciNumber(n - 1) + GetFibonacciNumber(n - 2);
            }
            //n=1返回0，n=2返回1
            return n-1;
        }
    }
}
