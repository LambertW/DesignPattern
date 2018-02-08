using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Adapter.ClassAdapter
{
    public abstract class ThreeHoleAdaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("我是三个孔的插头");
        }
    }
}
