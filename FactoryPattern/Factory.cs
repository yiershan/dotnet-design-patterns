using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    /// <summary>
    /// 简单工厂，和工厂模式对比用
    /// </summary>
    public class EasyFactory
    {
        // 简单工厂，根据字符串创建相应的对象
        public static Product CreateProduct(String name)
        {

            switch (name)
            {
                case "A":
                    return new ProductA();
                case "B":
                    return new ProductB();
                default:
                    throw new Exception("产品不存在！");
            }
        }
    }

    /// <summary>
    /// 抽象的工厂角色
    /// </summary>
    public abstract class Factory
    {
        /// <summary>
        /// 声明工厂方法，该方法返回一个Product类型的对象
        /// </summary>
        /// <returns></returns>
        public abstract Product CreateProduct();
    }
    /// <summary>
    /// 具体的工厂角色
    /// 创建具体ProductA的子工厂，
    /// </summary>
    public class FactoryA : Factory
    {
        /// <summary>
        /// 重写工厂方法以返回一个ProductA实例
        /// </summary>
        /// <returns></returns>
        public override Product CreateProduct()
        {
            return new ProductA();
        }
    }
    public class FactoryB : Factory
    {
        public override Product CreateProduct()
        {
            return new ProductB();
        }
    }

}
