using System.Drawing;

namespace DesignPattern.Visitor.Demo1
{
    public abstract class ShapeVisitor
    {
        public abstract void Visit(Rectangle shape);

        public abstract void Visit(Circle shape);

        public abstract void Visit(Line shape);
    }
}