using System;

namespace DesignPattern.Visitor.Demo1
{
    public class Rectangle : Shape
    {
        public override void Accept(ShapeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override void Draw()
        {
            Console.WriteLine("矩形我已经画好！");
        }
    }
}