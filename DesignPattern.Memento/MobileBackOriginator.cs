﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Memento
{
    public sealed class MobileBackOriginator
    {
        /// <summary>
        /// 发起人需要保存的内部状态
        /// </summary>
        private List<ContactPerson> _personList;

        public List<ContactPerson> ContactPersonList
        {
            get
            {
                return _personList;
            }

            set
            {
                _personList = value;
            }
        }

        /// <summary>
        /// 初始化需要备份的电话名单
        /// </summary>
        /// <param name="personList"></param>
        public MobileBackOriginator(List<ContactPerson> personList)
        {
            if (personList != null)
            {
                _personList = personList;
            }
            else
            {
                throw new ArgumentNullException("参数不能为空！");
            }
        }

        /// <summary>
        /// 创建备忘录对象实例，将当期要保存的联系人列表保存到备忘录对象中
        /// </summary>
        /// <returns></returns>
        public ContactPersonMemento CreateMemento()
        {
            return new ContactPersonMemento(new List<ContactPerson>(this._personList));
        }

        // 将备忘录中的数据备份还原到联系人列表中
        public void RestoreMemento(ContactPersonMemento memento)
        {
            ContactPersonList = memento.ContactPersonListBack;
        }

        public void Show()
        {
            Console.WriteLine("联系人列表中共有{0}个人，他们是:", ContactPersonList.Count);
            foreach (ContactPerson p in ContactPersonList)
            {
                Console.WriteLine("姓名: {0} 号码: {1}", p.Name, p.MobileNumber);
            }
        }

    }
}
