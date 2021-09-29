using System.Collections.Generic;

namespace CodeWarsTests.DesignPatternsTasks.CafeteriaCoffeBuilder
{
    class CoffeeBuilder
    {
        private Coffee coffee;
        public CoffeeBuilder()
        {
            coffee = new Coffee();
            coffee.Sugar = new List<Sugar>();
            coffee.Milk = new List<Milk>();
        }

        public CoffeeBuilder SetBlackCoffee()
        {

            coffee.Sort = "Black";
            return this;
        }
        public CoffeeBuilder SetCubanoCoffee()
        {
            coffee.Sort = "Cubano";
            this.WithMilk(null);
            this.WithSugar("Brown");


            return this;
        }
        public CoffeeBuilder SetAntoccinoCoffee()
        {
            coffee.Sort = "Americano";
            this.WithMilk(0.5);
            this.WithSugar(null);
            return this;
        }

        public CoffeeBuilder WithMilk(double? fat)
        {
            if (fat.HasValue)
            {
                coffee.Milk.Add(new Milk(fat.Value));
            }

            return this;
        }
        public CoffeeBuilder WithSugar(string sort)
        {
            if (sort != null)
            {
                coffee.Sugar.Add(new Sugar(sort));
            }
            return this;
        }

        public Coffee Build()
        {
            return this.coffee;
        }
    }
}
