using CSharpGrammarLearnConsole.JudgeConditions;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpGrammarLearnConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //求1+2+3+„„+10的和。
            //CumulativeSum.Method1();
            //CumulativeSum.Method2();
            //CumulativeSum.Method3();
            //CumulativeSum.Method4();
            //CumulativeSum.Method5();

            //光明小学六年级选出的男生的1/11和12名女生参加数学竞赛，剩下的男生人数是剩下的女生人数的2倍.已知六年级共有156人，问男、女生各有多少人？
            //Exhaustion.GetNumberOfBoysAndGirls1();
            //Exhaustion.GetNumberOfBoysAndGirls2();

            //输出所有的“水仙花数”，所谓“水仙花数”是指一个三位数，其中各位数字立方和等于该数字本身。例如：153是一个“水仙花数”，因为153=1*1*1+5*5*5+3*3*3。
            //Exhaustion.GetArmstrongNumber(100,999);

            //精度
            //Exhaustion.Precision();

            //任意输入三个整数，然后按从小到大的顺序输出。
            //NumberSort.SortMethod();

            //购买排骨
            //BuyProductFormMarket.BuyRibs();
            //购买猪蹄or排骨
            //BuyProductFormMarket.BuyTrottersOrRibs();

            //旅行的选择
            //Tourism.SelectTourism();

            //斐波那契数列
            var fibonacciNumber = FibonacciNumber.GetFibonacciNumber(10);
            Console.WriteLine($"{fibonacciNumber}");

            Console.ReadLine();
        }

        
    }
}
