using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton
{
    /// <summary>
    /// C#语言特性（内联初始化）
    /// </summary>
    public class Singleton3
    {
        public static readonly Singleton3 _instance = new Singleton3();

        private Singleton3() { }
    }
}
