namespace CodeWarsTests.DesignPatternsTasks.PatternCraft5
{
    public class MarineWeaponUpgrade : IMarine
    {
        private IMarine marine;

        public MarineWeaponUpgrade(IMarine marine)
        {
            this.marine = marine;
        }

        public int Damage
        {
            get { return this.marine.Damage + 1; ; }
            set { this.marine.Damage = value; }
        }

        public int Armor
        {
            get { return this.marine.Armor; }
            set { this.marine.Armor = value; }
        }
    }
}
