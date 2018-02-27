using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Interpreter
{
    public class QianExpression : Expression
    {
        public override string GetPostFix()
        {
            return "千";
        }

        public override int Multiplier()
        {
            return 1000;
        }
    }
}
