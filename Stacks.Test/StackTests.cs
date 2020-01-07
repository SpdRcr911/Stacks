using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stack.Library;

namespace Stacks.Test
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void CanPopOffItem()
        {
            var stack = new MyStack<string>();
            
            var fooStack = stack.Push("foo");
            Assert.AreEqual(0, stack.Count);
            Assert.AreEqual(1, fooStack.Count);

            var result = fooStack.Peek();
            Assert.AreEqual("foo", result);
            Assert.AreEqual("foo", fooStack.Peek());

            var emptyStack = fooStack.Pop();
            Assert.AreEqual(0, emptyStack.Count);
            Assert.AreEqual(1, fooStack.Count);

        }

    }
}
