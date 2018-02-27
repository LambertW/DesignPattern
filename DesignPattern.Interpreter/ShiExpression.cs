using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Interpreter
{
    public class ShiExpression : Expression
    {
        public override string GetPostFix()
        {
            return "十";
        }

        public override int Multiplier()
        {
            return 10;
        }
    }
}
