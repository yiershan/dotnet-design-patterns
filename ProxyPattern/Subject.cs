using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    /// <summary>
    /// 通用接口定义
    /// </summary>
    public interface ISubject
    {
        void Say();
    }
    /// <summary>
    /// 被代理者
    /// </summary>
    public class Subject : ISubject
    {
        public void Say()
        {
            Console.WriteLine("Hello");
        }
    }
    /// <summary>
    /// 代理
    /// </summary>
    public class Proxy : ISubject
    {
        private Subject _subject;
        public void Say()
        {
            if (_subject == null) {
                _subject = new Subject();
            }
            _subject.Say();
        }
    }
}
