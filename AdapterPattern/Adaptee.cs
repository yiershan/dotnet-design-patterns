using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    /// <summary>
    /// 需要适配的类，
    /// </summary>
    public class Adaptee
    {
        /// <summary>
        /// 不能直接被客户使用的方法
        /// </summary>
        public void SpecificRequest()
        {
            Console.WriteLine("这是原有特殊方法！");
        }
    }
}
