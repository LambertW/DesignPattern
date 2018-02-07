using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder
{
    /// <summary>
    /// 指挥者,封装对固定算法的实现
    /// </summary>
    public class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildCarDoor();
            builder.BuildCarEngine();
            builder.BuildCarWheel();
        }
    }
}
