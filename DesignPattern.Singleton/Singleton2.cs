using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton
{
    /// <summary>
    /// 双重锁定 Double Check
    /// </summary>
    public sealed class Singleton2
    {
        private static volatile Singleton2 _unqiueInstance;

        /// <summary>
        /// 定义一个标识确保线程同步
        /// </summary>
        private static readonly object locker = new object();

        public Singleton2() { }

        public static Singleton2 GetInstance()
        {
            if (_unqiueInstance == null)
            {
                lock (locker)
                {
                    if (_unqiueInstance == null)
                        _unqiueInstance = new Singleton2();
                }
            }

            return _unqiueInstance;
        }
    }
}
