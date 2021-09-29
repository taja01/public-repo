namespace CodeWarsTests.DesignPatternsTasks.PatternCracft
{
    public class MarioAdapter : IUnit
    {
        private Mario mario;
        public MarioAdapter(Mario mario)
        {
            this.mario = mario;
        }

        public void Attack(Target target)
        {
            target.Health -= this.mario.jumpAttack();
        }
    }
}
