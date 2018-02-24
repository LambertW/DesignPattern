namespace DesignPattern.Visitor.Demo2
{
    public abstract class Goods
    {
        public abstract void Operate(Visitor visitor);

        public int Size { get; set; }

        public int State { get; set; }
    }
}