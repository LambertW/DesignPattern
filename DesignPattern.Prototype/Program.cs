using System;

namespace DesignPattern.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Prototype xingZheSun = new XingZheSunPrototype().Clone();
            Prototype xingZheSun2 = new XingZheSunPrototype().Clone();
            Prototype xingZheSun3 = new XingZheSunPrototype().Clone();

            Prototype sunXingZhe = new SunXingZhePrototype().Clone();
            Prototype sunXingZhe2 = new SunXingZhePrototype().Clone();
            Prototype sunXingZhe3 = new SunXingZhePrototype().Clone();
            Prototype sunXingZhe4 = new SunXingZhePrototype().Clone();
            Prototype sunXingZhe5 = new SunXingZhePrototype().Clone();

            //1号孙行者打妖怪
            sunXingZhe.Fight();
            //2号孙行者去化缘
            sunXingZhe2.BegAlms();


            Console.Read();
        }
    }
}
