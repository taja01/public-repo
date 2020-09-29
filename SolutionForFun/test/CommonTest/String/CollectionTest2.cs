using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace CommonTest.String
{
    [TestFixture]
    public partial class CollectionTest
    {
        [Test]
        public void IsInAlphabeticalOrder2_Test0()
        {
            var collection = new List<string> { "a", "b", "c" };
            CultureInfo culture = new CultureInfo("en-GB");
            var result = collection.OrderBy(f => f, StringComparer.Create(culture, false));
            CollectionAssert.AreEqual(result, collection);
        }

        [Test]
        public void IsInAlphabeticalOrder2_Test1()
        {
            var collection = new List<string> { "Brazil", "Chile", "Egypt", "Italy", "Russia", "UEFA" };
            CultureInfo culture = new CultureInfo("en-GB");
            var result = collection.OrderBy(f => f, StringComparer.Create(culture, false));
            CollectionAssert.AreEqual(result, collection);
        }

        [Test]
        public void IsInAlphabeticalOrder2_Test2()
        {
            var collection = new List<string> { "Brazil U20", "Chile Primera Division", "Egypt Premier League", "Italy Coppa Primavera", "Russia Regional Leagues", "UEFA Europa League" };
            CultureInfo culture = new CultureInfo("en-GB");
            var result = collection.OrderBy(f => f, StringComparer.Create(culture, false));
            CollectionAssert.AreEqual(result, collection);
        }

        [Test]
        public void IsInAlphabeticalOrder2_Test5()
        {
            var collection = new List<string> { "Esports", "Κρίκετ", "Μπάσκετ", "Πινγκ-Πονγκ", "Τένις", "Χόκεϊ επί πάγου" };
            CultureInfo culture = new CultureInfo("el-CY");
            var result = collection.OrderBy(f => f, StringComparer.Create(culture, false));
            CollectionAssert.AreEqual(result, collection);
        }

        [Test]
        public void IsInAlphabeticalOrder2_Test6()
        {
            var collection = new List<string> { "Α", "Β", "Γ", "Δ", "Ε", "Ζ", "Η", "Θ" };
            CultureInfo culture = new CultureInfo("el-CY");
            var result = collection.OrderBy(f => f, StringComparer.Create(culture, false));
            CollectionAssert.AreEqual(result, collection);
        }

        [Test]
        public void IsInAlphabeticalOrder2_Test8()
        {
            var collection = new List<string> { "f", "ζ" };
            CultureInfo culture = new CultureInfo("el-CY");
            var result = collection.OrderBy(f => f, StringComparer.Create(culture, false));
            CollectionAssert.AreEqual(result, collection);
        }
    }
}
