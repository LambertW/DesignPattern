using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Adapter.ObjectAdapter
{
    public class TwoHoleTarget
    {
        public virtual void Request()
        {
            Console.WriteLine("两孔的充电器可以使用");
        }
    }
}
