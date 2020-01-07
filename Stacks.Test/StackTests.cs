using System;
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
        [TestMethod]
        public void CanPopOffMultipleItmes()
        {
            var stack = new MyStack(100);
            stack.Push("foo");
            stack.Push("bar");
            Assert.AreEqual("bar", stack.Pop());
            Assert.AreEqual("foo", stack.Pop());
        }
        [TestMethod]
        public void CanPopFromEmptyStack()
        {
            var stack = new MyStack(100);
            Assert.AreEqual(null, stack.Pop());
        }
        [TestMethod]
        public void ShouldFailWhenPushingNull()
        {
            var stack = new MyStack(100);
            Assert.ThrowsException<ArgumentNullException>(() => 
                {
                    stack.Push(null);
                }
            );
        }
        [TestMethod]
        public void ShouldFailWhenPushingOverStuffing()
        {
            var stack = new MyStack(1);
            Assert.ThrowsException<Exception>(() => 
                {
                    stack.Push("null");
                    stack.Push("null");
                }
            );
        }
    }
}
