using NUnit.Framework;
using System.Linq;
using TestNinja.Fundamentals;
namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math math;

        [SetUp]
        public void Setup()
        {
            math = new Math();
        }

        [Test]
        [Ignore("Ignorando Teste Que não desejo Executar")]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            var result = math.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(1, 2, 2)]
        [TestCase(2, 1, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            var result = math.Max(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetOddNumbers_Limit_IsGreaterThanZero_ReturnOddNumberUpToLimit()
        {
            var result = math.GetOddNumbers(5);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(3));

            Assert.That(result, Does.Contain(1));
            Assert.That(result, Does.Contain(3));
            Assert.That(result, Does.Contain(5));

            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));

            Assert.That(result, Is.Ordered);
            Assert.That(result, Is.Unique);
        }
    }
}
