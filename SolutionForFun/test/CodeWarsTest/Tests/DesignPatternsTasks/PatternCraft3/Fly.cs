namespace CodeWarsTests.DesignPatternsTasks.PatternCraft3
{
    public class Fly : IMoveBehavior
    {
        public void Move(IUnit unit)
        {
            unit.Position += 10;
        }
    }
}
