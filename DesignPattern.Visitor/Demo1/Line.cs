using System;

namespace DesignPattern.Visitor.Demo1
{
    public class Line : Shape
    {
        public override void Accept(ShapeVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override void Draw()
        {
            Console.WriteLine("直线我已经画好！");
        }
    }
}