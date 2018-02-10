using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator
{
    public abstract class House
    {
        /// <summary>
        /// 房子的装修方法--该操作相当于Component类型的Operation方法
        /// </summary>
        public abstract void Renovation();
    }
}
