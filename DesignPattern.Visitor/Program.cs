using System;

namespace DesignPattern.Visitor
{
    class Program
    {
        static void Main(string[] args)
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

            Console.ReadLine();
        }
    }
}
