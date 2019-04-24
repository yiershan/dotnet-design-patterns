using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Client
    {
        private Product _product;
        private ProductType _productType;

        public Client(Factory factory)
        {
            _product = factory.CreateProduct();
            _productType = factory.CreateProductType();
        }

        public void Run()
        {
            Console.WriteLine(_product.GetName(_productType));
        }
    }
}
