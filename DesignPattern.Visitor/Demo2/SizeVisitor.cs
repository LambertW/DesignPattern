using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Visitor.Demo2
{
    public sealed class SizeVisitor : Visitor
    {
        public override void PutComputer(Computer comp)
        {
            Console.WriteLine("按商品大小{0}排放", comp.Size);
        }

        public override void PutTelevision(Television tv)
        {
            Console.WriteLine("按商品大小{0}排放", tv.Size);
        }
    }
}
