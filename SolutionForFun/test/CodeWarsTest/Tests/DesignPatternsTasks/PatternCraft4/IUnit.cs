namespace CodeWarsTests.DesignPatternsTasks.PatternCraft4
{
    public interface IUnit
    {
        IUnitState State { get; set; }
        bool CanMove { get; }
        int Damage { get; }
    }
}
