using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Visitor.Demo2
{
    public sealed class StateVisitor : Visitor
    {
        public override void PutComputer(Computer comp)
        {
            Console.WriteLine("按商品新旧值{0}排放", comp.State);
        }

        public override void PutTelevision(Television tv)
        {
            Console.WriteLine("按商品新旧值{0}排放", tv.State);
        }
    }
}
