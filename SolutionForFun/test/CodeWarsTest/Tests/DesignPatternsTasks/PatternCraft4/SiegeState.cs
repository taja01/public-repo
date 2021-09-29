namespace CodeWarsTests.DesignPatternsTasks.PatternCraft4
{
    public class SiegeState : IUnitState
    {
        public SiegeState()
        {

        }

        public bool CanMove { get; set; } = false;
        public int Damage { get; set; } = 20;
    }
}
