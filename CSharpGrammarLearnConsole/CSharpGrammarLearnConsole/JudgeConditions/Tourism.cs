using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpGrammarLearnConsole.JudgeConditions
{
    internal static class Tourism
    {
        internal static void SelectTourism()
        {
            var selectedTourism = "你最终选择前往的目的地";
            switch (selectedTourism)
            {
                case "日本":
                    //做前往日本的旅行攻略
                    break;
                case "拉萨":
                    //做前往拉萨的旅行攻略
                    break;
                case "泰国":
                    //做前往泰国的旅行攻略
                    break;
                default:
                    //选择什么的太困难了，还是宅家里吧
                    break;
            }
        }
    }
}
