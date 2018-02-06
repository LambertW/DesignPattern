using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton
{
    /// <summary>
    /// 单例模式实现
    /// </summary>
    public class Singleton
    {
        /// <summary>
        /// 定义一个静态变量来保存类的实例
        /// </summary>
        private static Singleton _uniqueInstance;

        /// <summary>
        /// 定义私有构造函数，外界无法直接创建
        /// </summary>
        private Singleton()
        { }

        /// <summary>
        /// 全局访问点
        /// </summary>
        /// <returns></returns>
        public static Singleton GetInstance()
        {
            if(_uniqueInstance == null)
            {
                _uniqueInstance = new Singleton();
            }
            return _uniqueInstance;
        }
    }
}
