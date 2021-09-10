using CodeWarsTests.DesignPatternsTasks.CafeteriaCoffeBuilder;
using NUnit.Framework;
using System.Collections.Generic;

namespace CodeWarsTests.Tests.DesignPatternTests
{
    [TestFixture]
    public class CoffeeBuilderTests
    {
        [Test]
        public void Test1()
        {
            var actual = new CoffeeBuilder().SetBlackCoffee().WithSugar("Regular").WithMilk(3.2).Build();
            var expected = new Coffee("Black", new List<Milk> { new Milk(3.2) }, new List<Sugar> { new Sugar("Regular") });
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [Test]
        public void Test2()
        {
            var actual = new CoffeeBuilder().SetAntoccinoCoffee().Build();
            var expected = new Coffee("Americano", new List<Milk> { new Milk(0.5) }, new List<Sugar>());
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [Test]
        public void Test3()
        {
            var actual = new CoffeeBuilder().SetCubanoCoffee().Build();
            var expected = new Coffee("Cubano", new List<Milk>(), new List<Sugar> { new Sugar("Brown") });
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
    }
}
