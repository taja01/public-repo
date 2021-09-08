namespace CodeWarsTests.DesignPatternsTasks.PatternCraft2
{
    public interface ILightUnit
    {
        int Health { get; set; }

        void Accept(IVisitor visitor);
    }
}
