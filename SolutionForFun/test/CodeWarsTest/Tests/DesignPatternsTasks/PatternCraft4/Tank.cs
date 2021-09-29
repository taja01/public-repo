namespace CodeWarsTests.DesignPatternsTasks.PatternCraft4
{
    public class Tank : IUnit
    {
        public Tank()
        {
            State = new TankState();
        }

        public IUnitState State { get; set; }

        public bool CanMove => State.CanMove;
        public int Damage => State.Damage;
    }
}
