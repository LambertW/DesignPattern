using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Adapter.ClassAdapter
{
    public class ThreeToTwoAdapter : ThreeHoleAdaptee, ITwoHoleTarget
    {
        public void Request()
        {
            this.SpecificRequest();
        }
    }
}
