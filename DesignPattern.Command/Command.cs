using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Command
{ 
    /// <summary>
    /// 该类型就是抽象命令角色--Commmand，定义了命令的抽象接口，任务是包饺子
    /// </summary>
    public abstract class Command
    {
        /// <summary>
        /// 真正任务的接受者
        /// </summary>
        protected PatrickLiuAndWife _worker;

        protected Command(PatrickLiuAndWife worker)
        {
            _worker = worker;
        }

        public abstract void MakeDumplings();
    }
}
