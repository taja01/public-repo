namespace CodeWarsTests.DesignPatternsTasks.PatternCracft
{
    public class Zergling : IUnit
    {
        public void Attack(Target target)
        {
            target.Health -= 5;
        }
    }
}
