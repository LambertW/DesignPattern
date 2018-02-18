using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer
{
    /// <summary>
    /// 北京银行短信系统，是被观察者--该类型相当于具体主体角色ConcreteSubject
    /// </summary>
    public sealed class BeiJingBankMessageSystem : BankMessageSystem
    {
        public BeiJingBankMessageSystem()
        {
        }

        //增加预约储户
        public override void Add(Depositor depositor)
        {
            //应该先判断该用户是否存在，存在不操作，不存在则增加到储户列表中，这里简化了
            observers.Add(depositor);
        }

        //删除预约储户
        public override void Delete(Depositor depositor)
        {
            //应该先判断该用户是否存在，存在则删除，不存在无操作，这里简化了
            observers.Remove(depositor);
        }
    }
}
