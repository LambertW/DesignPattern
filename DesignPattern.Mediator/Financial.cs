using System;

namespace DesignPattern.Mediator
{
    public class Financial : Department
    {
        public Financial(Mediator mediator) : base(mediator)
        {
        }

        public override void Apply()
        {
            Console.WriteLine("数钱！");
        }

        public override void Process()
        {
            Console.WriteLine("汇报工作！没钱了，钱太多了！怎么花?");
        }
    }
}