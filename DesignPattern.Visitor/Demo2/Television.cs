namespace DesignPattern.Visitor.Demo2
{
    public class Television : Goods
    {
        public override void Operate(Visitor visitor)
        {
            visitor.PutTelevision(this);
        }
    }
}