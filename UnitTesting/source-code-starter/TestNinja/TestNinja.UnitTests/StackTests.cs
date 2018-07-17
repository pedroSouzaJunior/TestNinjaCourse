using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class StackTests
    {
        private Stack<int?> stack;

        [SetUp]
        public void Setup()
        {
            stack = new Stack<int?>();
        }

        [Test]
        public void Push_WhenCalled_ReturnsIncrementOfStack()
        {
            stack.Push(1);
            Assert.That(stack, Is.Not.Null);
            Assert.That(stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Push_WhenCalledWithNullObject_ThrowsArgumentNullException()
        {
            Assert.That(()=>stack.Push((int?)null), Throws.ArgumentNullException);
            
        }
    }
}
