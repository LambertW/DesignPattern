using System;

namespace DesignPattern.Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            PlatformImplementor sqlServer2000UnixImp = new SqlServer2000UnixImplementor();

            Database sqlServer2000Unix = new SqlServer2000(sqlServer2000UnixImp);

            sqlServer2000Unix.Create();

            Console.Read();
        }
    }
}
