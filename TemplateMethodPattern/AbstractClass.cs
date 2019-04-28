using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    /// <summary>
    /// 模板
    /// </summary>
    public abstract class AbstractClass
    {
        /// 子类需要实现此方法
        protected abstract int _count();
        protected abstract int _add();
        /// <summary>
        /// 一个算法，或者一个过程。
        /// </summary>
        /// <param name="input"></param>
        public void Count(int input) {
            var result = this._count()*input+_add()-20;
            Console.WriteLine(result);
        }
    }
    /// <summary>
    /// 实现10倍+100
    /// </summary>
    public class ConcreteClass10 : AbstractClass
    {
        protected override int _add()
        {
            return 100;
        }

        protected override int _count()
        {
            return 10;
        }
    }
    /// <summary>
    /// 实现20倍+2
    /// </summary>
    public class ConcreteClass20 : AbstractClass
    {
        protected override int _add()
        {
            return 2;
        }

        protected override int _count()
        {
            return 20;
        }
        
    }
}
