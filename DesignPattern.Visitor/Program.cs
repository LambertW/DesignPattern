using System;

namespace DesignPattern.Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo1();

            Demo2();

            Console.Read();
        }

        private static void Demo2()
        {
            Demo2.StoragePlatform platform = new Demo2.StoragePlatform();
            platform.Attach(new Demo2.Television());
            platform.Attach(new Demo2.Computer());

            Demo2.SizeVisitor sizeVisitor = new Demo2.SizeVisitor();
            Demo2.StateVisitor stateVisitor = new Demo2.StateVisitor();

            platform.Operate(sizeVisitor);
            platform.Operate(stateVisitor);
        }

        private static void Demo1()
        {
            //如果想执行新增加的操作
            Demo1.ShapeVisitor visitor = new Demo1.CustomVisitor();
            Demo1.AppStructure app = new Demo1.AppStructure(visitor);

            Demo1.Shape shape = new Demo1.Rectangle();
            shape.Draw();//执行自己的操作
            app.Process(shape);//执行新的操作

            shape = new Demo1.Circle();
            shape.Draw();//执行自己的操作
            app.Process(shape);//执行新的操作

            shape = new Demo1.Line();
            shape.Draw();//执行自己的操作
            app.Process(shape);//执行新的操作
        }
    }
}
