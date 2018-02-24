namespace DesignPattern.Visitor.Demo2
{
    public class Computer : Goods
    {
        public override void Operate(Visitor visitor)
        {
            visitor.PutComputer(this);
        }
    }
}