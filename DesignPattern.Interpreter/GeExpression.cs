using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Interpreter
{
    public class GeExpression : Expression
    {
        public override string GetPostFix()
        {
            return "";
        }

        public override int Multiplier()
        {
            return 1;
        }

        public override int GetLength()
        {
            return 1;
        }
    }
}
