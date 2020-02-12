using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpGrammarLearnConsole
{
    internal static class NumberSort
    {
        internal static void SortMethod(int count=3)
        {
            List<int> numbers = new List<int>();
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine($"请输入第{i + 1}个整数：");
                var numberStr = Console.ReadLine();
                var number = int.Parse(numberStr);
                numbers.Add(number);
            }
            numbers = numbers.OrderBy(x=>x).ToList();
            Console.WriteLine("从小到大排序结果如下：");
            foreach(var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
