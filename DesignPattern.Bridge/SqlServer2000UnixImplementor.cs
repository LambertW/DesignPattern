using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge
{
    public class SqlServer2000UnixImplementor : PlatformImplementor
    {
        public override void Process()
        {
            Console.WriteLine("SqlServer2000针对Unix的具体实现");
        }
    }
}
