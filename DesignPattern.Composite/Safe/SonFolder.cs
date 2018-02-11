using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Composite.Safe
{
    /// <summary>
    /// SonFolder类型就是树枝构件，现在由于我们使用的是“安全式”，所以Add,Remove都是从此处开始定义的
    /// </summary>
    public abstract class SonFolder : Folder
    {
        //增加文件夹或文件
        public abstract void Add(Folder folder);

        //删除文件夹或者文件
        public abstract void Remove(Folder folder);

        //打开文件夹--该操作相当于Component类型的Operation方法
        public override void Open()
        {
            Console.WriteLine("已经打开当前文件夹");
        }
    }
}
