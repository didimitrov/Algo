using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StackImplementation.Test
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void CustomStack_StackPushTest()
        {
            var actual = new CustomStack<int>();
            for (int i = 0; i < 10; i++)
            {
                actual.Push(i);
            }

            const int expected = 10;

            Assert.AreEqual(actual.Count, expected);
        }

        [TestMethod]
        public void CustomStack_StackPopTest()
        {
            var actual = new CustomStack<int>();
            for (int i = 0; i < 10; i++)
            {
                actual.Push(i);
            }
            for (int i = 0; i < 5; i++)
            {
                actual.Pop();
            }
            const int expected = 5;

            Assert.AreEqual(actual.Count, expected);
        }

        [TestMethod]
        [ExpectedException(typeof (InvalidOperationException))]
        public void CustomStack_StackEmptyPushTest()
        {
            var actual = new CustomStack<int>();

            actual.Pop();
        }

        [TestMethod]
        public void CustomStack_StackCorrectPeekTest()
        {
            var mystack = new CustomStack<int>();

            for (int i = 0; i < 10; i++)
            {
                mystack.Push(i);
            }

            var actual = mystack.Peek();
            var expected = 9;

            Assert.AreEqual(actual, expected);
        }
    }
}

