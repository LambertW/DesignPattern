using System;

namespace DesignPattern.Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Iterator iterator;
            ITroopQueue list = new ConcreteTroopQueue();
            iterator = list.GetIterator();

            while (iterator.MoveNext())
            {
                string ren = (string)iterator.GetCurrent();
                Console.WriteLine(ren);
                iterator.Next();
            }

            Console.Read();
        }
    }
}
