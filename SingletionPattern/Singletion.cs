using System;
using System.Collections.Generic;
using System.Text;

namespace SingletionPattern
{
    /// <summary>
    /// 单件模式实现方式：简单线程安全。
    /// </summary>
    public sealed class Singletion
    {
        //私有构造函数，防止通过new实例化对象
        private Singletion() {
        }
        //定义一个静态变量来保存类的实例
        private static Singletion _instance;
        //定义一个标识确保线程同步
        private static readonly object _lock = new object();
        //定义公有静态方法，获取实例，并加入判断，保证实例只被创建一次
        public static Singletion GetInstance() {
            if (_instance == null) {
                //锁，多线程时，保证实例只被创建一次
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singletion();
                    }
                }
            }
            return _instance;
        }
        public string GetName() {
            return "我是单例模式";
        }
    }
}
