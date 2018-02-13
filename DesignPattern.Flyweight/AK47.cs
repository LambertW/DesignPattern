using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Flyweight
{
    public class AK47 : Weapen
    {
        public override void Fire(string jobName)
        {
            Console.WriteLine(jobName);
        }
    }
}
