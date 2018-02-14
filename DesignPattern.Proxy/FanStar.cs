using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Proxy
{
    /// <summary>
    /// 该类型是Fan姓明星，有钱有势，想炒什么炒什么---相当于具体的RealSubject角色
    /// </summary>
    public class FanStar : AgentAbstract
    {
        public FanStar()
        {
        }

        /// <summary>
        /// 要有名气，定期要炒作---就是RealSubject类型的Request方法
        /// </summary>
        /// <param name="thing"></param>
        public override void Speculation(string thing)
        {
            Console.WriteLine(thing);
        }
    }
}
