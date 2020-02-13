using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpGrammarLearnConsole.JudgeConditions
{
    internal static class BuyProductFormMarket
    {
        /// <summary>
        /// 购买排骨
        /// </summary>
        internal static void BuyRibs()
        {
            //获得一个“市场”实例对象
            Market market = new Market("菜市场");

            string ribs = "排骨";
            var price = market.GetPrice(ribs);
            if (price <= 35)
            {
                //购买排骨
                market.Buy(ribs, 3);
            }
            else
            {
                //什么都不做，这个else代码段可以不写
            }
        }

        /// <summary>
        /// 购买猪蹄or排骨
        /// </summary>
        internal static void BuyTrottersOrRibs()
        {
            Market market = new Market("菜市场");

            string ribs = "排骨";
            string trotters = "猪蹄";
            var isHaveTrotters = market.IsHaveProduct(trotters);
            if (isHaveTrotters)
            {
                var trottersPrice= market.GetPrice(trotters);
                if (trottersPrice <= 40)
                {
                    market.Buy(trotters, 2);
                    //“回家”，后面的逻辑不再执行
                    return;
                }
            }
            var isHaveRibs = market.IsHaveProduct(ribs);
            if (isHaveRibs)
            {
                market.Buy(ribs, 3);
            }
        }
    }
}
