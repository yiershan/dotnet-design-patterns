using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class Factory
    {
        public abstract Product CreateProduct();

        public abstract ProductType CreateProductType();
    }

    public class FactoryA1 : Factory
    {
        public override Product CreateProduct()
        {
            return new ProductA();
        }

        public override ProductType CreateProductType()
        {
            return new ProductType1();
        }
    }
    public class FactoryB2 : Factory
    {
        public override Product CreateProduct()
        {
            return new ProductB();
        }

        public override ProductType CreateProductType()
        {
            return new ProductType2();
        }
    }
}
