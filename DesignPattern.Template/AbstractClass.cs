using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Template
{
    public abstract class AbstractClass
    {
        /// <summary>
        /// 该方法就是模板方法，方法里面包含了做饺子的算法步骤，模板方法可以返回结果，也可以是void类型，视具体情况而定
        /// </summary>
        public void EatDumplings()
        {
            //和面
            MakingDough();
            //包馅
            MakeDumplings();
            //煮饺子
            BoiledDumplings();

            Console.WriteLine("饺子真好吃！");
        }

        //要想吃饺子第一步肯定是“和面”---该方法相当于算法中的某一步
        public abstract void MakingDough();

        //要想吃饺子第二部是“包饺子”---该方法相当于算法中的某一步
        public abstract void MakeDumplings();

        //要想吃饺子第三部是“煮饺子”---该方法相当于算法中的某一步
        public abstract void BoiledDumplings();
    }
}
