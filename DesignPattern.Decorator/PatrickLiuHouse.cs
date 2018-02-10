using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator
{
    public sealed class PatrickLiuHouse : House
    {
        public override void Renovation()
        {
            Console.WriteLine("装修PatrickLiu的房子");
        }
    }
}
