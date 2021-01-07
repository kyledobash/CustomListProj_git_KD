using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListProj_actual_KD;

namespace CustomListTests
{
    [TestClass]
    class AdditionOperaterTests
    {
        [TestMethod]
        public void AdditionOperator_TwoSingleItemLists_ReturnsFirstListWith2Items()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();

            testList1.Add(1);
            testList2.Add(2);

            int expected = 2;
            int actual;

            // act
            testList1 + testList2;
            actual = testList1[1];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AdditionOperator_EmptyListPlusSingleItemList_ReturnsFirstListWith1Item()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();

            testList2.Add(1);

            int expected = 1;
            int actual;

            // act
            testList1 + testList2;
            actual = testList1[0];

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
