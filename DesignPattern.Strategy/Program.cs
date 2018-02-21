using System;

namespace DesignPattern.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            //普通员工的工资
            SalaryContext context = new SalaryContext(new NormalPeopleSalary());
            context.GetSalary(3000);

            //CEO的工资
            context.ISalaryStrategy = new CEOSalary();
            context.GetSalary(6000);

            Console.Read();

        }
    }
}
