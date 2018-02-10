using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator
{
    public sealed class KeepWarmDecorator : DecorationStrategy
    {
        public KeepWarmDecorator(House house) : base(house)
        {
        }

        public override void Renovation()
        {
            base.Renovation();
            Console.WriteLine("增加保温的功能");
        }
    }
}
