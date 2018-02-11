using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Composite.Safe
{
    /// <summary>
    /// 该抽象类就是文件夹抽象接口的定义，该类型就相当于是抽象构件Component类型
    /// </summary>
    public abstract class Folder
    {
        public abstract void Open();
    }
}
