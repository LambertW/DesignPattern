using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Iterator
{
    public interface Iterator
    {
        bool MoveNext();
        Object GetCurrent();
        void Next();
        void Reset();
    }
}
