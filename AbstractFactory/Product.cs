using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    /// <summary>
    /// 产品
    /// </summary>
    public abstract class Product
    {
        public abstract string GetName(ProductType productType);
    }
    /// <summary>
    /// 产品类型
    /// </summary>
    public abstract class ProductType
    {
        public abstract string GetProductType();
    }

    public class ProductA : Product
    {
        public override string GetName(ProductType productType)
        {
            return "我是A产品，型号是"+productType.GetProductType();
        }
    }
    public class ProductB : Product
    {
        public override string GetName(ProductType productType)
        {
            return "我是B产品，型号是"+productType.GetProductType();
        }
    }
    public class ProductType1 : ProductType
    {
        public override string GetProductType()
        {
            return "1";
        }
    }
    public class ProductType2 : ProductType
    {
        public override string GetProductType()
        {
            return "2";
        }
    }
}
