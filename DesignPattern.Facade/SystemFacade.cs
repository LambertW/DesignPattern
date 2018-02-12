using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Facade
{
    public class SystemFacade
    {
        private AuthoriationSystemA auth;
        private SecuritySystemB security;
        private NetBankSystemC netbank;

        public SystemFacade()
        {
            auth = new AuthoriationSystemA();
            security = new SecuritySystemB();
            netbank = new NetBankSystemC();
        }

        public void Buy()
        {
            auth.MethodA();//身份认证子系统
            security.MethodB();//系统安全子系统
            netbank.MethodC();//网银安全子系统

            Console.WriteLine("我已经成功购买了！");
        }

    }
}
