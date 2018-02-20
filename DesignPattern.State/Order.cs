using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State
{
    public sealed class Order
    {
        private IState _currentState;

        public Order()
        {
            //工作状态初始化为上午工作状态
            _currentState = new WaitForAcceptance();
            IsCancel = false;
        }

        private double minute;
        public double Minute
        {
            get { return minute; }
            set { minute = value; }
        }

        public bool IsCancel { get; set; }

        private bool finish;
        public bool TaskFinished
        {
            get { return finish; }
            set { finish = value; }
        }

        public void SetState(IState s)
        {
            _currentState = s;
        }

        public void Action()
        {
            _currentState.Process(this);
        }
    }
}
