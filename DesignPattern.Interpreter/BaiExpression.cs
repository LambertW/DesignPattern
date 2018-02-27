using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Interpreter
{
    public class BaiExpression : Expression
    {
        public override string GetPostFix()
        {
            return "百";
        }

        public override int Multiplier()
        {
            return 100;
        }
    }
}
