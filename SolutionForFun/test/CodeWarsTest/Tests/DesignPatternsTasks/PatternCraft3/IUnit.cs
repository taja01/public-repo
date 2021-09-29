namespace CodeWarsTests.DesignPatternsTasks.PatternCraft3
{
    public interface IUnit
    {
        int Position { get; set; }
        void Move();
        IMoveBehavior MoveBehavior { get; set; }
    }
}
