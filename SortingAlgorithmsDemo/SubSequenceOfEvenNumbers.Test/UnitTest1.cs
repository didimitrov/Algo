using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _04.SubseqenceofEvenNumbers;

namespace SubSequenceOfEvenNumbers.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestFindSequenceNullInput()
        {
            ListUtils.FindLongestSubseqence(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestFindSubsequenceInvalidEmptyInput()
        {
            ListUtils.FindLongestSubseqence(new List<int>());
        }

        [TestMethod]
        public void TestSubSequenceCorrectOutput()
        {
            var actual= ListUtils.FindLongestSubseqence(new List<int>() {1, 2, 6, 3, 4, 2, 2, 2, 2, 2, 33, 1, 1});

            var expected = new List<int> {2, 2, 2, 2, 2};

           CollectionAssert.AreEqual(actual, expected);
        }
    }
}
