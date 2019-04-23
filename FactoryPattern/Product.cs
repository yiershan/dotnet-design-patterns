
namespace FactoryPattern
{
    /// <summary>
    /// 定义Product抽象类，Client调用Product抽象类，并由Factory来创建具体类。
    /// </summary>
    public abstract class Product
    {
        public abstract string GetName();
    }
    /// <summary>
    /// A产品
    /// </summary>
    public class ProductA : Product
    {
        public override string GetName()
        {
            return "我是A产品！";
        }
    }
    /// <summary>
    /// B产品
    /// </summary>
    public class ProductB : Product
    {
        public override string GetName()
        {
            return "我是B产品！";
        }
    }
}
