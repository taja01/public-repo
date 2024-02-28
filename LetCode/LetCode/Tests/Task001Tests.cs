using LetCode.Tasks;

namespace LetCode.Tests
{
    internal class Task001Tests
    {
        [Test]
        public void Test1()
        {
            var numbers = new[] { 2, 7, 11, 15 };
            var result = Task001.TwoSum(numbers, 9);

            Assert.That(result, Is.EqualTo(new[] { 0, 1 }));
        }

        [Test]
        public void Test2()
        {
            var numbers = new[] { 3, 3 };
            var result = Task001.TwoSum(numbers, 6);

            Assert.That(result, Is.EqualTo(new[] { 0, 1 }));
        }

        [Test]
        public void Test3()
        {
            var numbers = new[] { 1, 5, 3 };
            var result = Task001.TwoSum(numbers, 5);

            Assert.That(result, Is.EqualTo(new int[] { }));
        }
    }
}
