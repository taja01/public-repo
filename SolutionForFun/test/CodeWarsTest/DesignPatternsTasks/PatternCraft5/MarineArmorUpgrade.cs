namespace CodeWarsTests.DesignPatternsTasks.PatternCraft5
{
    public class MarineArmorUpgrade : IMarine
    {
        private IMarine marine;

        public MarineArmorUpgrade(IMarine marine)
        {
            this.marine = marine;

        }

        public int Damage
        {
            get { return this.marine.Damage; }
            set { this.marine.Damage = value; }
        }

        public int Armor
        {
            get { return this.marine.Armor + 1; }
            set { this.marine.Armor = value; }
        }
    }
}
