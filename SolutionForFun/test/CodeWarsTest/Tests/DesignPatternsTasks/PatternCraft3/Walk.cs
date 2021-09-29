namespace CodeWarsTests.DesignPatternsTasks.PatternCraft3
{
    public class Walk : IMoveBehavior
    {
        public void Move(IUnit unit)
        {
            unit.Position += 1;
        }
    }
}
