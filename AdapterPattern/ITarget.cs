using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    /// <summary>
    /// 客户能够直接使用的接口
    /// </summary>
    public interface ITarget
    {
        void Request();
    }
}
