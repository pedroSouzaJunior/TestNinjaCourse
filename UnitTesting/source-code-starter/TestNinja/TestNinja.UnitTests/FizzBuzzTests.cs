using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(2, "2")]
        public void GetOutput_WhenCalledWithNumberDivisibleForTree_ReturnFizz(int num, string expectedResult)
        {
            var result = FizzBuzz.GetOutput(num);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
