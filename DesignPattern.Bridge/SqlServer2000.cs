using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge
{
    public class SqlServer2000 : Database
    {
        public SqlServer2000(PlatformImplementor implementor) 
            : base(implementor)
        {

        }

        public override void Create()
        {
            _implementor.Process();
        }
    }
}
