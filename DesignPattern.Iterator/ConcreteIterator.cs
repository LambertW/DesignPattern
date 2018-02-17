namespace DesignPattern.Iterator
{
    internal class ConcreteIterator : Iterator
    {
        private ConcreteTroopQueue _concreteTroopQueue;
        private int _index;

        public ConcreteIterator(ConcreteTroopQueue concreteTroopQueue)
        {
            _concreteTroopQueue = concreteTroopQueue;
        }

        public object GetCurrent()
        {
            return _concreteTroopQueue.GetElement(_index);
        }

        public bool MoveNext()
        {
            if (_index < _concreteTroopQueue.Length)
                return true;

            return false;
        }

        public void Next()
        {
            if(_index < _concreteTroopQueue.Length)
            {
                _index++;
            }
        }

        public void Reset()
        {
            _index = 0;
        }
    }
}