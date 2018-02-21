using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Strategy
{
    public class NormalPeopleSalary : ISalaryStrategy
    {
        public void CalculateSalary(double income)
        {
            Console.WriteLine("我的工资是：基本工资(" + income + ")底薪(3000)+加班费");
        }

    }
}
