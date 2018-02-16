using System;

namespace DesignPattern.Command
{
    class Program
    {
        static void Main(string[] args)
        {
            //奶奶想吃猪肉大葱馅的饺子
            PatrickLiuAndWife liuAndLai = new PatrickLiuAndWife();//命令接受者
            Command command = new MakeDumplingsCommand(liuAndLai);//命令
            PaPaInvoker papa = new PaPaInvoker(command); //命令请求者

            //奶奶发布命令
            papa.ExecuteCommand();

            Console.Read();
        }
    }
}
