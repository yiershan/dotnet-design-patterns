﻿##定义
>  桥接模式的用意是将抽象化(Abstraction)与实现化(Implementation)脱耦，使得二者可以独立地变化。

当一个抽象可能有多个实现时，通常用继承来进行协调。抽象类定义对该抽象的接口，而具体的子类则用不同的方式加以实现。继承机制将抽象部分与它的实现部分固定在一起，使得难以对抽象部分和实现部分独立地进行修改、扩充和重用。

　　如果一个抽象类或接口有多个具体实现子类，而这些子类之中有内容或概念上重叠，需要我们把抽象的共同部分各自独立开来：即原来是准备放在一个接口里，现在需要设计两个接口——抽象接口和行为接口。然后再分别针对各自的具体子类定义抽象接口和行为接口的方法和调用关系。
> 抽象化(Abstraction)

　　存在于多个实体中的共同的概念性联系，即为抽象化。作为一个过程，抽象化就是忽略一些信息，从而把不同的实体当做同样的实体对待。
> 实现化(Implementation)

　　抽象化给出的具体实现，即为实现化。

> 脱耦

　　耦合是指两个对象的行为的某种强关联，脱耦则是要去掉它们之间的强关联。在这里，脱耦是指将抽象化和实现化之间的耦合解脱，或者将它们之间的强关联改换成弱关联。将两者之间的继承关系改为聚合关系，就是将它们之间的强关联改换成为弱关联。
　　桥接模式中的脱耦，是指抽象化和实现化之间使用组合/聚合关系，而不是继承关系，从而使两者可以相对独立地变化。
## 桥接模式参与者：
-  Abstraction：定义抽象类的接口，它维护了一个指向Implementor类型对象的指针。
-  RefinedAbstraction：扩充由Abstraction定义的接口；
- Implementor：定义实现类的接口，该接口不一定要与Abstraction的接口完全一致，事实上两个接口可以完全不同。一般情况，Implementor接口仅为提供基本操作，而Abstraction则定义了基于基本操作的较高层次操作。
- ConcreteImplementorA和ConcreteImplementorB：实现Implementor接口并定义它的具体实现。

    在桥接模式中，两个类Abstraction和Implementor分别定义了抽象与行为类型的接口，通过调用两接口的子类实现抽象与行为的动态组合。


## 桥接模式可以适用于以下情形：
-  不希望在抽象与实现部分之间有固定的绑定关系；
- 类的抽象以及它的实现都应该可以通过生成子类的方法加以扩充。这时桥接模式可以对不同的抽象接口和实现部分进行组合，并分别对它们进行扩充；
- 对抽象的实现部分进行修改应对客户不产生影响，即客户的代码不必重新编译；
-  想对客户完全隐藏抽象的实现部分；
- 想在多个对象间共享实现，但同时要求客户并不知道这点。
## 桥接模式具有以下特点：
- 分离接口及其实现部分，一个实现未必不变地绑定在一个接口上。抽象类的实现可以在运行时刻进行配置，一个对象甚至可以在运行时刻改变它的实现；
-  将Abstraction与Implementor分离有助于降低对实现部分编译时刻的依赖性；当改变一个实现类时，并不需要重新编译Abstraction类和Client类。为了保证一个类库的不同版本之间的兼容，需要有这个特性；
- 接口与实现分离有助于分层，从而产生更好的结构化系统。系统的高层部分仅需要知道Abstraction和Implementor即可；
- 提高可扩充性。可以独立的对Abstraction和Implementor层次结构进行扩充；
- 实现细节对Client透明。可以对Client隐藏实现细节，如共享Implementor对象以及相应的引用计数机制。