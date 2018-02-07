using System;
using System.Collections;
using System.Collections.Generic;

namespace DesignPattern.Builder
{
    public class Car
    {
        private IList<string> parts = new List<string>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("汽车开始组装..........");

            foreach (var part in parts)
            {
                Console.WriteLine("组件" + part + "已装好");
            }

            Console.WriteLine("汽车组装好了");
        }
    }
}