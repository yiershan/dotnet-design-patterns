## 定义（工厂模式又称工厂方法模式）
>工厂方法模式定义一个用于创建对象的接口，让子类决定实例化哪一个类。工厂方法模式是以一个类的实例化延迟到其子类。

　　Factory Method模式用于在不指定待创建对象的具体类的情况下创建对象。

　　Factory Method模式的主要意图是隐藏对象创建的复杂性。Client通常不指定要创建的具体类，Client将面向接口或抽象类进行编码，让Factory类负责创建具体的类型。通常Factory类有一个返回抽象类或者接口的静态方法。Client通常提供某种信息让Factory类使用提供的信息来确定创建并返回哪个子类。

　　将创建子类的责任抽象出来的好处是允许Client完全无需考虑依赖类是如何创建的，这遵守依赖倒置原则（Dependency Inversion Principle，DIP）。Factory Method模式另外一个好处是把负责对象创建的代码集中起来，如果需要修改对象生成方式，可以轻松定位并更新，而不会影响到依赖它的代码。

　　在面向对象编程中，一般方法是用一个new操作符产生一个对象的实例。但是在一些情况下，用new操作符直接生成对象会带来一些问题。首先，要使用new运算符创建一个对象必须清楚所要创建的对象的类信息，包括类名、构造函数等，而有时并不现实。其次许多类型的对象创建需要一系列的步骤，可能需要计算或取得对象的初始设置，选择生成那个子对象实例，或在生成需要的对象之前必须生成一些辅助功能的对象。在这些情况下，新对象的建立就是一个过程，而不是一个简单的操作。为轻松方便地完成复杂对象的创建，从而引入了工厂模式。
##  C#例子

```
    public abstract class Product
    {
        public abstract string GetName();
    }

    public class ProductA : Product
    {
        public override string GetName()
        {
            return "我是A产品！";
        }
    }
    public class ProductB:Product
    {
        public override string GetName()
        {
            return "我是B产品！";
        }
    }

    public abstract class Factory
    {
        public abstract Product CreateProduct();
    }
    public class FactoryA : Factory
    {
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

    class Program
    {
        static void Main(string[] args)
        {
            Factory[] factories = new Factory[2];

            factories[0] = new FactoryA();
            factories[1] = new FactoryB();

            foreach (var factory in factories)
            {
                Product product = factory.CreateProduct();
                Console.WriteLine(product.GetName());
            }
            Console.ReadLine();
        }
    }
```

## 工厂方法模式参与者：

- Product：Product角色，定义工厂方法所创建的对象的接口
- Product*：具体Product角色，实现Product接口
-  Factory：抽象的工厂角色，声明工厂方法，该方法返回一个Product类型的对象。
Factory可以定义一个工厂方法的默认实现，返回一个默认的Product对象。可以调用工厂方法以创建一个Product对象。
- Factory*：具体的工厂角色，创建具体Product的子工厂，重写工厂方法以返回一个Product实例


## 工厂方法模式适用情形

- 当一个类不知道它所必须创建的对象的类信息的时候
- 当一个类希望由它来指定它所创建的对象的时候
- 当类将创建对象的职责委托给多个辅助子类中的某一个，并且希望将哪一个辅助之类是代理者这一信息局部化的时候

## 工厂方法模式特点
- 使用工厂方法在一个类的内部创建对象通常比直接创建对象更灵活
- 工厂方法模式通过面向对象的手法，将所要创建的具体对象的创建工作延迟到子类，从而提供了一种扩展的策略，较好的解决了紧耦合的关系
- 工厂方法模式遵守依赖倒置原则（Dependency Inversion Principle，DIP）
## 其他
>工厂方法模式与简单工厂模式区别

- 工厂方法模式和简单工厂模式在结构上的不同是很明显的。工厂方法模式的核心是一个抽象工厂类，而简单工厂模式把核心放在一个具体工厂类上。工厂方法模式可以允许很多具体工厂类从抽象工厂类中将创建行为继承下来，从而可以成为多个简单工厂模式的综合，进而推广了简单工厂模式。
- 工厂方法模式退化后可以变得很像简单工厂模式。如果非常确定一个系统只需要一个具体工厂类，那么就不妨把抽象工厂类合并到具体的工厂类中去。由于只有一个具体工厂类，所以不妨将工厂方法改成为静态方法，这时候就得到了简单工厂模式

## 参考文章

[设计模式-工厂模式（Factory Method）](https://www.jianshu.com/p/c655346bd751)

