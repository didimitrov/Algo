using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _05.RemoveNegativeNumbers;

namespace RemoveNegativeNumbers.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TetsRemoveNegativeNumbersNullInput()
        {
            ListUtils.RemoveNegativeNums(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ListUtils_RemoveNegativeElementsInvalidEmptyInputTest()
        {
            ListUtils.RemoveNegativeNums(new List<int>());
        }

        [TestMethod]
        public void TestRemoveNegativeCorrectOutput()
        {
            var actual = ListUtils.RemoveNegativeNums(new List<int> {1, 2, 3, -12, 3, -12});
            var expected = new List<int>() { 1, 2, 3, 3 };

            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestRemoveNegativeAllNegativeInput()
        {
            var actual = ListUtils.RemoveNegativeNums(new List<int> { -1, -2, -3, -12, -3, -12 });
            var expected = new List<int>();

            CollectionAssert.AreEqual(actual, expected);
        }
    }
}
