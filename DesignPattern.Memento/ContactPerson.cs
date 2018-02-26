using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Memento
{
    /// <summary>
    /// 联系人--需要备份的数据，是状态数据，没有操作
    /// </summary>
    public class ContactPerson
    {
        //姓名
        public string Name { get; set; }

        //电话号码
        public string MobileNumber { get; set; }
    }
}
