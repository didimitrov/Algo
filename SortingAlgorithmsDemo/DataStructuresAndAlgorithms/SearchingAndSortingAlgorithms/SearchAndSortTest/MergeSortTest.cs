using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _01.SearchAndSort;

namespace SearchAndSortTest
{
    [TestClass]
    public class MergeSortTest
    {
        [TestMethod]
        public void SimpleMergeSortTest()
        {
            var listToSort = new List<int> {2, 5, 3, 1, 4};
            var expected = new List<int> {1, 2, 3, 4, 5};
            var sorter = new MergeSorter<int>();

            var actual = sorter.Mergesorter(listToSort).ToList();

            CollectionAssert.AreEqual(actual, expected);

        }
        [TestMethod]
        public void SortedNumbersTest()
        {
            var listToSort = new List<int> { 1, 2, 3, 4, 5 };
            var sorter = new MergeSorter<int>();

            var actual = sorter.Mergesorter(listToSort).ToList();
            var expected = new List<int> { 1, 2, 3, 4, 5 };

            CollectionAssert.AreEqual(actual, expected);

        }
    }
}
