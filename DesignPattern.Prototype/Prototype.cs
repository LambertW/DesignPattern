using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Prototype
{
    /// <summary>
    /// 抽象原型
    /// </summary>
    public abstract class Prototype
    {
        public abstract void Fight();

        public abstract void BegAlms();

        public abstract Prototype Clone();
    }
}
