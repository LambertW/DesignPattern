using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Prototype
{
    public class SunXingZhePrototype : Prototype
    {
        // 战斗--保护师傅-与天界宠物战斗
         public override void Fight()
         {
             Console.WriteLine("腾云驾雾，各种武艺");
         }
         // 化缘--不要饿着师傅---水果类
         public override void BegAlms()
         {
             Console.WriteLine("什么都能要来");
         }
 
         // 吹口仙气--变化一个自己出来
         public override Prototype Clone()
         {
             return (SunXingZhePrototype) this.MemberwiseClone();
         }
    }
}
