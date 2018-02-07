using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder
{
    /// <summary>
    /// 抽象建造者
    /// </summary>
    public abstract class Builder
    {
        // 1.创建部件
        public abstract void BuildCarDoor();

        public abstract void BuildCarWheel();

        public abstract void BuildCarEngine();

        // 2.最终创建结果
        public abstract Car GetCar();
    }
}
