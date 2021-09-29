namespace CodeWarsTests.DesignPatternsTasks.PatternCraft4
{
    public class TankState : IUnitState
    {
        public TankState()
        {

        }

        public bool CanMove { get; set; } = true;
        public int Damage { get; set; } = 5;
    }
}
