using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton
{
    public sealed class Singleton1
    {
        private static volatile Singleton1 _unqiueInstance;

        /// <summary>
        /// 定义一个标识确保线程同步
        /// </summary>
        private static readonly object locker = new object();

        public Singleton1() { }

        public static Singleton1 GetInstance()
        {
            lock (locker)
            {
                if (_unqiueInstance == null)
                    _unqiueInstance = new Singleton1();
            }

            return _unqiueInstance;
        }
    }
}
