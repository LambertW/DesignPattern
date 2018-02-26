using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Memento
{
    public sealed class ContactPersonMemento
    {
        // 保存发起人创建的电话名单数据，就是所谓的状态
        public List<ContactPerson> ContactPersonListBack { get; private set; }

        public ContactPersonMemento(List<ContactPerson> personList)
        {
            ContactPersonListBack = personList;
        }
    }
}
