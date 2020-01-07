using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stacks.Library;

namespace Stacks.Test
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void CanPopOffItem()
        {
            var stack = new MyStack(100);
            stack.Push("foo");
            Assert.AreEqual("foo", stack.Pop());
        }
    }
}
