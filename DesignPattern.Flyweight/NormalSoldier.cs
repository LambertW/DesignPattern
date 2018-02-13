using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Flyweight
{
    /// <summary>
    /// 一般类型的战士，武器就是步枪---相当于具体的Flyweight角色
    /// </summary>
    public class NormalSoldier : Soldier
    {
        public NormalSoldier(string name): base(name) { }

        /// <summary>
        /// 执行享元的方法---就是Flyweight类型的Operation方法
        /// </summary>
        public override void Fight()
        {
            WeapenInstance.Fire("士兵：" + Name + " 在陆地执行击毙任务");
        }
    }
}
