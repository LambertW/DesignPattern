using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Visitor.Demo2
{
    public sealed class StoragePlatform
    {
        private IList<Goods> list = new List<Goods>();

        public void Attach(Goods element)
        {
            list.Add(element);
        }

        public void Detach(Goods element)
        {
            list.Remove(element);
        }

        public void Operate(Visitor visitor)
        {
            foreach (Goods g in list)
            {
                g.Operate(visitor);
            }
        }
    }
}
