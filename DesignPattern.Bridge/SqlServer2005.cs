using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge
{
    public class SqlServer2005 : Database
    {
        public SqlServer2005(PlatformImplementor implementor)
            : base(implementor)
        {
        }

        public override void Create()
        {
            _implementor.Process();
        }
    }
}
