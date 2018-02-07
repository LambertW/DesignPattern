using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactory
{
    /// <summary>
    /// 抽象工厂类，提供创建不同类型房子的接口
    /// </summary>
    public abstract class AbstractFactory
    {
        public abstract Roof CreateRoof();
        public abstract Floor CreateFloor();
        public abstract Window CreateWindow();
        public abstract Door CreateDoor();
    }
}
