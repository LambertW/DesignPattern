using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryMethod
{
    /// <summary>
    /// 抽象工厂类
    /// </summary>
    public abstract class Factory
    {
        /// <summary>
        /// 工厂方法
        /// </summary>
        /// <returns></returns>
        public abstract Car CreateCar();
    }
}
