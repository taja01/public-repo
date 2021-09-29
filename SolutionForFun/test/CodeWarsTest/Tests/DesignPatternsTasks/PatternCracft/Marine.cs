namespace CodeWarsTests.DesignPatternsTasks.PatternCracft
{
    public class Marine : IUnit
    {
        public void Attack(Target target)
        {
            target.Health -= 6;
        }
    }
}
