using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Flyweight
{
    /// <summary>
    /// 这是海军陆战队队员，武器精良----相当于具体的Flyweight角色
    /// </summary>
    public class WaterSoldier : Soldier
    {
        public WaterSoldier(string name) : base(name)
        {
        }

        /// <summary>
        /// 执行享元的方法---就是Flyweight类型的Operation方法
        /// </summary>
        public override void Fight()
        {
            WeapenInstance.Fire("士兵：" + Name + " 在海中执行击毙任务");
        }
    }
}
