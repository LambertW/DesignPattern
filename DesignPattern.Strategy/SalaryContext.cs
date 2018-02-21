using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Strategy
{
    public sealed class SalaryContext
    {
        private ISalaryStrategy _strategy;

        public SalaryContext(ISalaryStrategy strategy)
        {
            _strategy = strategy;
        }

        public ISalaryStrategy ISalaryStrategy
        {
            get { return _strategy; }
            set { _strategy = value; }
        }

        public void GetSalary(double income)
        {
            _strategy.CalculateSalary(income);
        }
    }
}
