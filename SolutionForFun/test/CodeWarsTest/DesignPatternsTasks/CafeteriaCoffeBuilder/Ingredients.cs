using System.Collections.Generic;

namespace CodeWarsTests.DesignPatternsTasks.CafeteriaCoffeBuilder
{
    struct Milk
    {
        public double Fat;

        public Milk(double fat) : this()
        {
            this.Fat = fat;
        }
    }

    struct Sugar
    {
        public string Sort;

        public Sugar(string sort) : this()
        {
            this.Sort = sort;
        }
    }

    struct Coffee
    {
        public string Sort;
        public List<Milk> Milk;
        public List<Sugar> Sugar;

        public Coffee(string sort, List<Milk> milks, List<Sugar> sugars) : this()
        {
            this.Sort = sort;
            this.Milk = milks;
            this.Sugar = sugars;
        }
    }
}
