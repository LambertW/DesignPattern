using System;

namespace DesignPattern.Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            SoldierFactory factory = new SoldierFactory();
            AK47 ak47 = new AK47();
            for (int i = 0; i < 100; i++)
            {
                Soldier soldier = null;
                if (i <= 20)
                {
                    soldier = factory.GetSoldier("士兵" + (i + 1), ak47, SoldierType.Normal);
                }
                else
                {
                    soldier = factory.GetSoldier("士兵" + (i + 1), ak47, SoldierType.Water);
                }
                soldier.Fight();
            }

            //我们有这么多的士兵，但是使用的内存不是很多，因为我们缓存了。
            Console.Read();
        }
    }
}
