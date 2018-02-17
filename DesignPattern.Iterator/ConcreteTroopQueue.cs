using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Iterator
{
    public sealed class ConcreteTroopQueue : ITroopQueue
    {
        private string[] _collecton;

        public ConcreteTroopQueue()
        {
            _collecton = new string[] { "黄飞鸿", "方世玉", "洪熙官", "严咏春" };
        }

        public Iterator GetIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Length
        {
            get { return _collecton.Length; }
        }

        public string GetElement(int index)
        {
            return _collecton[index];
        }
    }
}
