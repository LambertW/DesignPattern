using System;

namespace DesignPattern.Command
{
    /// <summary>
    /// 该类型是具体命令接受角色Receiver，具体包饺子的行为是我们夫妻俩来完成的
    /// </summary>
    public class PatrickLiuAndWife
    {
        //这个方法相当于Receiver类型的Action方法
        public void Execute(string job)
        {
            Console.WriteLine(job);
        }
    }
}