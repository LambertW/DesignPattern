using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Prototype
{
    public class XingZheSunPrototype : Prototype
    {
        // 战斗--保护师傅--与自然修炼成妖的战斗
         public override void Fight()
         {
             Console.WriteLine("腾云驾雾，各种武艺");
         }
         // 化缘--不要饿着师傅--饭食类
         public override void BegAlms()
         {
             Console.WriteLine("什么都能要来");
         }
 
         // 吹口仙气--变化一个自己出来
         public override Prototype Clone()
         {
             return (XingZheSunPrototype) this.MemberwiseClone();
         }
    }
}
