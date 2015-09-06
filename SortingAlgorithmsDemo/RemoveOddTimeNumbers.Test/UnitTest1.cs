using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _06.RemoveOddTimeNumbers;

namespace RemoveOddTimeNumbers.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RemoveOddNullINput()
        {
            ListUtils.RemoveOdd(null);
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentNullException))]
        public void TestRemoveOddEmptyInput()
        {
            ListUtils.RemoveOdd(new List<int>());
        }

        [TestMethod]
        public void TestRemoveOddCorrectResult()
        {
            var actual = ListUtils.RemoveOdd(new List<int>() {1, 1, 1, 2, 3, 3, 6, 6});
            var expected = new List<int> {3, 3, 6, 6};

            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestRemoveOddAllOddInput()
        {
            var actual = ListUtils.RemoveOdd( new List<int>() { 1, 1, 1, 2 });
            var expected = new List<int>();

            CollectionAssert.AreEqual(actual, expected);
        }
    }
}
