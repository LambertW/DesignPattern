using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator
{
    public sealed class HouseSecurityDecorator : DecorationStrategy
    {
        public HouseSecurityDecorator(House house) : base(house)
        {
        }

        public override void Renovation()
        {
            base.Renovation();
            Console.WriteLine("增加安全系统");
        }
    }
}
