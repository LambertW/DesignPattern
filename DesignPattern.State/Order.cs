using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State
{
    public sealed class Order
    {
        private State current;

        public Order()
        {
            //工作状态初始化为上午工作状态
            current = new WaitForAcceptance();
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
        public void SetState(State s)
        {
            current = s;
        }
        public void Action()
        {
            current.Process(this);
        }
    }
}
