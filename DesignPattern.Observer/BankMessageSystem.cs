using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer
{
    /// <summary>
    /// 银行短信系统抽象接口，是被观察者--该类型相当于抽象主体角色Subject
    /// </summary>
    public abstract class BankMessageSystem
    {
        protected IList<Depositor> observers;

        protected BankMessageSystem()
        {
            observers = new List<Depositor>();
        }

        //增加预约储户
         public abstract void Add(Depositor depositor);
 
         //删除预约储户
         public abstract void Delete(Depositor depositor);
 
         //通知储户
         public void Notify()
         {
             foreach (Depositor depositor in observers)
             {
                 if (depositor.AccountIsChanged)
                 {
                     depositor.Update(depositor.Balance, depositor.OperationDateTime);
                     //账户发生了变化，并且通知了，储户的账户就认为没有变化
                     depositor.AccountIsChanged = false;
                 }
             }
         }
     }
}
