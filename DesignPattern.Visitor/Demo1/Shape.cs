using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Visitor.Demo1
{
    public abstract class Shape
    {
        //画图形
        public abstract void Draw();
        //外界注入具体访问者
        public abstract void Accept(ShapeVisitor visitor);
    }
}
