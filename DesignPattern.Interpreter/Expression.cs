using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Interpreter
{
    public abstract class Expression
    {
        protected Dictionary<string, int> _table = new Dictionary<string, int>(9);

        protected Expression()
        {
            _table.Add("一", 1);
            _table.Add("二", 2);
            _table.Add("三", 3);
            _table.Add("四", 4);
            _table.Add("五", 5);
            _table.Add("六", 6);
            _table.Add("七", 7);
            _table.Add("八", 8);
            _table.Add("九", 9);
        }

        public virtual void Interpreter(Context context)
        {
            if (context.Statement.Length == 0)
            {
                return;
            }

            foreach (string key in _table.Keys)
            {
                int value = _table[key];

                if (context.Statement.EndsWith(key + GetPostFix()))
                {
                    context.Data += value * this.Multiplier();
                    context.Statement = context.Statement.Substring(0, context.Statement.Length - this.GetLength());
                }
                if (context.Statement.EndsWith("零"))
                {
                    context.Statement = context.Statement.Substring(0, context.Statement.Length - 1);
                }
            }
        }

        public abstract string GetPostFix();

        public abstract int Multiplier();

        //这个可以通用，但是对于个位数字例外，所以用虚方法
        public virtual int GetLength()
        {
            return this.GetPostFix().Length + 1;
        }

    }
}
