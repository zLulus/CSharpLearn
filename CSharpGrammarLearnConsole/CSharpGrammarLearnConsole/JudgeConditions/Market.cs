using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpGrammarLearnConsole.JudgeConditions
{
    /// <summary>
    /// 市场类
    /// </summary>
    internal class Market
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="marketName"></param>
        internal Market(string marketName)
        {
            //可以在这里做一些初始化的工作
            //比如，使用"marketName"区分不同的菜市场
        }

        /// <summary>
        /// 查询货物是否有货
        /// </summary>
        /// <param name="productName">货物名称</param>
        /// <returns></returns>
        internal bool IsHaveProduct(string productName)
        {
            //未实现
            return true;
        }

        /// <summary>
        /// 查询货物价格
        /// </summary>
        /// <param name="productName">货物名称</param>
        /// <returns></returns>
        internal decimal GetPrice(string productName)
        {
            //未实现
            return -1;
        }

        /// <summary>
        /// 购买
        /// </summary>
        /// <param name="productName">货物名称</param>
        /// <param name="amount">购买数量</param>
        /// <returns></returns>
        internal bool Buy(string productName,decimal amount)
        {
            //未实现
            return true;
        }
    }
}
