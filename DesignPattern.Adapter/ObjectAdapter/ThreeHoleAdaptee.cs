using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Adapter.ObjectAdapter
{

    public class ThreeHoleAdaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("我是3个孔的插头也可以使用了");
        }
    }
}
