using System;

namespace DesignPattern.Mediator
{
    public class Market : Department
    {
        public Market(Mediator mediator) : base(mediator)
        {
        }

        public override void Apply()
        {
            Console.WriteLine("跑去接项目！");
        }

        public override void Process()
        {
            Console.WriteLine("汇报工作！项目承接的进度，需要资金支持！");
            GetMediator.Command(this);
        }
    }
}