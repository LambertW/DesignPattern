using System;

namespace DesignPattern.Visitor.Demo1
{
    public class Circle : Shape
    {
        public override void Accept(ShapeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override void Draw()
        {
            Console.WriteLine("圆形我已经画好！");
        }
    }
}