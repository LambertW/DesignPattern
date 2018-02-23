using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Visitor.Demo1
{
    public sealed class CustomVisitor : ShapeVisitor
    {
        public override void Visit(Rectangle shape)
        {
            Console.WriteLine("针对Rectangle新的操作！");
        }

        public override void Visit(Circle shape)
        {
            Console.WriteLine("针对Circle新的操作！");
        }

        public override void Visit(Line shape)
        {
            Console.WriteLine("针对Line新的操作！");
        }
    }
}
