using System;

namespace DesignPattern.Mediator
{
    public class Development : Department
    {
        public Development(Mediator mediator) : base(mediator)
        {
        }

        public override void Apply()
        {
            Console.WriteLine("专心科研，开发项目！");
        }

        public override void Process()
        {
            Console.WriteLine("我们是开发部门，要进行项目开发，没钱了，需要资金支持！");
        }
    }
}