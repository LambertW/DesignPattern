using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Visitor.Demo1
{
    public class AppStructure
    {
        private ShapeVisitor _visitor;

        public AppStructure(ShapeVisitor visitor)
        {
            _visitor = visitor;
        }

        public void Process(Shape shape)
        {
            shape.Accept(_visitor);
        }
    }
}
