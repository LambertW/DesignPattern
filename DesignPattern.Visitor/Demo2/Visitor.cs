using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Visitor.Demo2
{
    public abstract class Visitor
    {
        public abstract void PutTelevision(Television tv);

        public abstract void PutComputer(Computer comp);
    }
}
