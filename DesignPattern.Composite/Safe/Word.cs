using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Composite.Safe
{
    public sealed class Word : Folder
    {
        public override void Open()
        {
            Console.WriteLine("打开Word文档，开始进行编辑");
        }
    }
}
