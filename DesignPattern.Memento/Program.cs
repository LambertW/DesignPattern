using System;
using System.Collections.Generic;

namespace DesignPattern.Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ContactPerson> persons = new List<ContactPerson>()
            {
                new ContactPerson() { Name = "黄飞鸿", MobileNumber = "13533332222" },
                new ContactPerson() { Name = "方世玉", MobileNumber = "13966554433" },
                new ContactPerson() { Name = "洪熙官", MobileNumber = "13198765544" }
            };

            //手机名单发起人
            MobileBackOriginator mobileOriginator = new MobileBackOriginator(persons);
            mobileOriginator.Show();

            // 创建备忘录并保存备忘录对象
            MementoManager manager = new MementoManager();
            manager.ContactPersonMemento = mobileOriginator.CreateMemento();

            // 更改发起人联系人列表
            Console.WriteLine("----移除最后一个联系人--------");
            mobileOriginator.ContactPersonList.RemoveAt(2);
            mobileOriginator.Show();

            // 恢复到原始状态
            Console.WriteLine("-------恢复联系人列表------");
            mobileOriginator.RestoreMemento(manager.ContactPersonMemento);
            mobileOriginator.Show();

            Console.Read();

        }
    }
}
