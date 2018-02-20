using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State
{
    public interface IState
    {
        void Process(Order order);
    }
}
