using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Mediator
{
    public sealed class President : Mediator
    {
        //总经理有各个部门的管理权限
        private Financial _financial;
        private Market _market;
        private Development _development;

        public void SetFinancial(Financial financial)
        {
            _financial = financial;
        }

        public void SetDevelopment(Development development)
        {
            _development = development;
        }

        public void SetMarket(Market market)
        {
            _market = market;
        }

        public void Command(Department department)
        {
            if(department.GetType() == typeof(Market))
            {
                _financial.Process();
            }
        }
    }
}
