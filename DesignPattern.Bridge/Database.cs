using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge
{
    public abstract class Database
    {
        protected PlatformImplementor _implementor;

        protected Database(PlatformImplementor implementor)
        {
            _implementor = implementor;
        }

        public abstract void Create();
    }
}
