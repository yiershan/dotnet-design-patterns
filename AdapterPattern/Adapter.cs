using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    /// <summary>
    /// 适配器，负责Adaptee的接口与Target接口进行适配
    /// </summary>
    public class Adapter : Adaptee, ITarget
    {
        /// <summary>
        /// 转换成客户适应的方法
        /// </summary>
        public void Request()
        {
            SpecificRequest();
        }
    }
}
