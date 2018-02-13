using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Flyweight
{
    /// <summary>
    /// 该类型就是抽象战士Soldier--该类型相当于抽象享元角色
    /// </summary>
    public abstract class Soldier
    {
        public string Name { get; set; }

        protected Soldier(string name)
        {
            Name = name;
        }

        /// <summary>
        /// 可以传入不同的武器就用不同的活力---该方法相当于抽象Flyweight的Operation方法
        /// </summary>
        public abstract void Fight();

        public Weapen WeapenInstance { get; set; }
    }
}
