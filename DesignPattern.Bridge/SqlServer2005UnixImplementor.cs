using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge
{
    public class SqlServer2005UnixImplementor : PlatformImplementor
    {
        public override void Process()
        {
            Console.WriteLine("SqlServer2005针对Unix的具体实现");
        }
    }
}
