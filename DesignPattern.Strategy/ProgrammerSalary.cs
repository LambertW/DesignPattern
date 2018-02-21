using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Strategy
{
    public class ProgrammerSalary : ISalaryStrategy
    {
        public void CalculateSalary(double income)
        {
            Console.WriteLine("我的工资是：基本工资(" + income + ")底薪(" + 8000 + ")+加班费+项目奖金（10%）");
        }
    }
}
