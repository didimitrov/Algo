using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomLinkedList.Test
{
    [TestClass]
    public class UnitTest1
    {
        private DynamicList<int> linkedList;

        [TestInitialize]
        public void InitLinkedlist()
        {
            this.linkedList=new DynamicList<int>();
        }

        [TestMethod]
        public void TestCount()
        {
            Assert.AreEqual(0, linkedList.Count);
            linkedList.Add(1);
            Assert.AreEqual(1, linkedList.Count);
        }

        [TestMethod]
        public void TestRemoveWhenNotEmpty()
        {
            for (int i = 0; i < 100; i++)
            {
                linkedList.Add(i);
            }
            for (int i = 0; i < 100; i++)
            {
                linkedList.Remove(i);
            }
            Assert.AreEqual(0, linkedList.Count);
        }

        [TestMethod]
        public void TestRemoveWhenEmpty()
        {
            var removed = linkedList.Remove(5);
            Assert.AreEqual(-1, removed);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestRemoveAtWhenEmpty()
        {
            linkedList.RemoveAt(1);
        }

        [TestMethod]
        public void TestRemoveAtWhenNotEmpty()
        {
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);

            var removed = linkedList.RemoveAt(0);
            Assert.AreEqual(1, removed);
        }

        [TestMethod]
        public void IndexsationTest()
        {
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);

            Assert.AreEqual(1,linkedList[0]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGetIndexWhenEmpty()
        {
            var item = linkedList[1];
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SettingInvalidIndexTest()
        {
           
            linkedList[5] = 15;
        }
    }
}
