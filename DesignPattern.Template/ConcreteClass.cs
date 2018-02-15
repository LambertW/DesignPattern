using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Template
{
    public class ConcreteClass : AbstractClass
    {
        public override void BoiledDumplings()
        {
            Console.WriteLine("用我家的大铁锅和大木材煮饺子");
        }

        public override void MakeDumplings()
        {
            Console.WriteLine("农家猪肉和农家大葱，制作成馅");
        }

        public override void MakingDough()
        {
            Console.WriteLine("在和面的时候加入芹菜汁，和好的面就是绿色的");
        }
    }
}
