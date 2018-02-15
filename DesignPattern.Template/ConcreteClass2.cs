using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Template
{
    public class ConcreteClass2 : AbstractClass
    {
        public override void BoiledDumplings()
        {
            Console.WriteLine("可以用一般煤气和不粘锅煮就可以");
        }

        public override void MakeDumplings()
        {
            Console.WriteLine("农家鸡蛋和农家韭菜，制作成馅");
        }

        public override void MakingDough()
        {
            Console.WriteLine("在和面的时候加入胡萝卜汁，和好的面就是橙色的");
        }
    }
}
