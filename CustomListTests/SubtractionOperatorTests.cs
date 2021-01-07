using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListProj_actual_KD;

namespace CustomListTests
{
    [TestClass]
    public class SubtractionOperatorTests
    {
        [TestMethod]
        public void SubtractionOperator_TwoSingleItemLists_ResultListBecomesEmpty()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> resultList = new CustomList<int>();

            testList1.Add(1);
            testList2.Add(1);

            int expected = 0;
            int actual;

            // act
            resultList = testList1 - testList2;
            actual = resultList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubtractionOperator_TwoListsShareNoSameValues_ListRemainsTheSame()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> resultList = new CustomList<int>();

            testList1.Add(1);
            testList2.Add(2);

            int expected = 1;
            int actual;

            // act
            resultList = testList1 - testList2;
            actual = resultList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
