namespace CodeWarsTests.DesignPatternsTasks.GeeseToDuck
{
    public class GooseToIDuckAdapter : IDuck
    {
        private Goose _goose;
        public GooseToIDuckAdapter(Goose goose)
        {
            _goose = goose;
        }

        public void Fly()
        {
            _goose.Fly();
        }

        public string Quack()
        {
            return _goose.Honk();
        }
    }
}
