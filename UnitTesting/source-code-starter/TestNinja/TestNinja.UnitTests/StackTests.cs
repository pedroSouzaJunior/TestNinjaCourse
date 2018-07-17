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
            Assert.That(() => stack.Push((int?)null), Throws.ArgumentNullException);
        }

        [Test]
        public void Push_EmptyStack_CountEqualsZero()
        {
            Assert.That(stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Pop_EmptyStack_ThrowsInvalidOperationException()
        {
            Assert.That(() => stack.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void Pop_StackWithFewObjects_ReturnObjectOnTheTop()
        {
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            var result = stack.Pop();

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Pop_StackWithFewObjects_DecrementsCount()
        {
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Pop();

            Assert.That(stack.Count, Is.EqualTo(2));
        }


        [Test]
        public void Peek_EmptyStack_ThrowsInvalidOperationException()
        {
            Assert.That(() => stack.Peek(), Throws.InvalidOperationException);
        }

        [Test]
        public void Peek_StackWithFewObjects_ReturnObjectOnTheTop()
        {
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            var result = stack.Peek();

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Peek_StackWithFewObjects_DoesNotRemoveTheObjectOnTheTop()
        {
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Peek();

            Assert.That(stack.Count, Is.EqualTo(3));
        }
    }
}
