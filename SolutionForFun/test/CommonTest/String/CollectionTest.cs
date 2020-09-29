using NUnit.Framework;
using System.Collections.Generic;

namespace CommonTest.String
{
    [TestFixture]
    public partial class CollectionTest
    {
        [Test]
        public void Test0()
        {
            var collection = new List<string> { "a", "b", "c" };
            Assert.IsTrue(Helper.IsInAlphabeticalOrder(collection, "en-GB", out var message));
            Assert.IsNull(message);
        }

        [Test]
        public void Test1()
        {
            var collection = new List<string> { "Brazil", "Chile", "Egypt", "Italy", "Russia", "UEFA" };
            Assert.IsTrue(Helper.IsInAlphabeticalOrder(collection, "en-GB", out var message));
            Assert.IsNull(message);
        }

        [Test]
        public void Test2()
        {
            var collection = new List<string> { "Brazil U20", "Chile Primera Division", "Egypt Premier League", "Italy Coppa Primavera", "Russia Regional Leagues", "UEFA Europa League" };
            Assert.IsTrue(Helper.IsInAlphabeticalOrder(collection, "en-GB", out var message));
            Assert.IsNull(message);
        }

        [Test]
        public void Test3()
        {
            var collection = new List<string> { "Brazil U20", "Chile Primera Division", "UEFA Europa League", "Egypt Premier League", "Italy Coppa Primavera", "Russia Regional Leagues" };
            Assert.IsFalse(Helper.IsInAlphabeticalOrder(collection, "en-GB", out var message));
            Assert.IsNotEmpty(message);
        }

        [Test]
        public void Test4()
        {
            var collection = new List<string> { "Κρίκετ", "Μπάσκετ", "Πινγκ-Πονγκ", "Τένις", "Χόκεϊ επί πάγου", "Esports" };
            Assert.IsFalse(Helper.IsInAlphabeticalOrder(collection, "el-CY", out var message));
            Assert.IsNotEmpty(message);
        }

        [Test]
        public void Test5()
        {
            var collection = new List<string> { "Esports", "Κρίκετ", "Μπάσκετ", "Πινγκ-Πονγκ", "Τένις", "Χόκεϊ επί πάγου" };
            Assert.IsTrue(Helper.IsInAlphabeticalOrder(collection, "el-CY", out var message));
            Assert.IsNull(message);
        }

        [Test]
        public void Test6()
        {
            var collection = new List<string> { "Α", "Β", "Γ", "Δ", "Ε", "Ζ", "Η", "Θ" };
            Assert.IsTrue(Helper.IsInAlphabeticalOrder(collection, "el-CY", out var message));
            Assert.IsNull(message);
        }

        [Test]
        public void Test8()
        {
            var collection = new List<string> { "f", "ζ" };
            Assert.IsTrue(Helper.IsInAlphabeticalOrder(collection, "el-CY", out var message));
            Assert.IsNull(message);
        }
    }
}
