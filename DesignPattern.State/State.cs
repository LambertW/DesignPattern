using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State
{
    public interface State
    {
        void Process(Order order);
    }
}
