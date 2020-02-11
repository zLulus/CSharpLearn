using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpGrammarLearnConsole
{
    internal static class CumulativeSum
    {
        internal static void Method1()
        {
            var result = 0;
            result = result + 1;
            result = result + 2;
            result = result + 3;
            result = result + 4;
            result = result + 5;
            result = result + 6;
            result = result + 7;
            result = result + 8;
            result = result + 9;
            result = result + 10;
            Console.WriteLine(result);
        }

        internal static void Method2()
        {
            var result = 0;
            for (int i = 1; i <= 10; i++)
            {
                result = result + i;
            }
            Console.WriteLine(result);
        }

        internal static void Method3()
        {
            //询问
            Console.WriteLine($"求和1+2+3,,,+n，请输入n的具体数字。");
            //得到输入
            var n= Console.ReadLine();
            //C#是强类型，转换类型
            var endNumber = int.Parse(n);
            var result = 0;
            for (int i = 1; i <= endNumber; i++)
            {
                result = result + i;
            }
            Console.WriteLine(result);
        }

        internal static void Method4()
        {
            //询问
            Console.WriteLine($"求和1+2+3,,,+n，请输入n的具体数字。");
            //得到输入
            var n = Console.ReadLine();
            //C#是强类型，转换类型

            var endNumber = 0;
            bool isSuccess=int.TryParse(n,out endNumber);
            if (isSuccess==true)
            {
                var result = 0;
                for (int i = 1; i <= endNumber; i++)
                {
                    result = result + i;
                }
                Console.WriteLine($"1+2+3,,,+{endNumber}的结果：{result}");
            }
            else
            {
                Console.WriteLine($"错误的输入{n}");
            }
        }

        internal static void Method5()
        {
            //这里是一个无限循环，一般在开发中不常见，容易出现问题
            while (true)
            {
                Method4();
            }
        }
    }
}
