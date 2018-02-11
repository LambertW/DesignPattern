using DesignPattern.Composite.Transparent;
using System;

namespace DesignPattern.Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 透明式的组合模式
            Folder myWord = new Word();

            myWord.Open();

            // 抛出异常
            //myWord.Add(new SonFolder());
            //myWord.Remove(new SonFolder());

            Folder myFolder = new SonFolder();
            myFolder.Open();

            myFolder.Add(new SonFolder());
            myFolder.Remove(new SonFolder());
            #endregion

            #region 安全式的组合模式
            Safe.Folder myword = new Safe.Word();

            myword.Open();//打开文件，处理文件


            Safe.Folder myfolder = new Safe.NextFolder();
            myfolder.Open();//打开文件夹

            //此处要是用增加和删除功能，需要转型的操作，否则不能使用
            ((Safe.SonFolder)myfolder).Add(new Safe.NextFolder());//成功增加文件或者文件夹
            ((Safe.SonFolder)myfolder).Remove(new Safe.NextFolder());//成功删除文件或者文件夹

            #endregion

            Console.Read();
        }
    }
}
