namespace CodeWarsTests.DesignPatternsTasks.PatternCraft2
{
    public class Marine : ILightUnit
    {
        public int Health { get; set; } = 100;

        public void Accept(IVisitor visitor)
        {
            visitor.VisitLight(this);
        }
    }
}
