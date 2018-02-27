namespace DesignPattern.Interpreter
{
    public class Context
    {
        public string Statement { get; set; }
        public int Data { get; set; }

        public Context(string statement)
        {
            Statement = statement;
        }
    }
}