namespace CodeWarsTests.DesignPatternsTasks.PatternCraft2
{
    public interface IVisitor
    {
        void VisitLight(ILightUnit unit);
        void VisitArmored(IArmoredUnit unit);
    }
}
