using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpGrammarLearnConsole
{
    internal static class Exhaustion
    {
        internal static void GetNumberOfBoysAndGirls1()
        {
            for(int boysNumber=0; boysNumber<=156; boysNumber++)
            {
                var girlsNumber = 156 - boysNumber;
                //双等号表示“等于”
                //10.0/ 11.0不能改成10/ 11，涉及精度问题
                if ((10.0/ 11.0)  * boysNumber   == ((girlsNumber - 12) * 2))
                {
                    Console.WriteLine($"男生人数为{boysNumber}，女生人数为{girlsNumber}");
                    break;
                }
            }
            Console.WriteLine("运算完毕");
        }

        internal static void GetNumberOfBoysAndGirls2()
        {
            for (int boysNumber = 0; boysNumber <= 156; boysNumber++)
            {
                for(int girlsNumber=0; girlsNumber<=156; girlsNumber++)
                {
                    if ((girlsNumber + boysNumber == 156) &&
                        (10.0 / 11.0) * boysNumber == ((girlsNumber - 12) * 2))
                    {
                        Console.WriteLine($"男生人数为{boysNumber}，女生人数为{girlsNumber}");
                    }
                }
            }
            Console.WriteLine("运算完毕");
        }

        internal static void GetArmstrongNumber(int startIndex,int endIndex)
        {
            if(startIndex> endIndex)
            {
                Console.WriteLine($"输入的数据错误，起始数据大于终止数据");
                return;
            }
            Console.WriteLine($"获得{startIndex}-{endIndex}的水仙花数:");
            for(var target= startIndex; target <= endIndex; target++)
            {
                //也可以通过取余的方式获得数字的每一位
                var numberList = target.ToString().ToCharArray();
                double sum = 0;
                for (var index = 0; index < numberList.Length; index++)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(numberList[index]);
                    string s = sb.ToString();
                    var number = int.Parse(s);
                    sum += Math.Pow(number, 3);
                }
                if(sum== target)
                {
                    Console.WriteLine($"水仙花数：{target}");
                }
            }
            Console.WriteLine("运算完毕");
        }
        
        internal static void Precision()
        {
            var result1 = 10 / 11;
            Console.WriteLine($"10 / 11={result1}");
            var result2 = 10.0 / 11.0;
            Console.WriteLine($"10.0 / 11.0={result2}");
        }
    }
}
