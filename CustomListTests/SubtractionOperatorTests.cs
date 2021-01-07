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

            testList1.Add(1);
            testList2.Add(1);

            int expected = 0;
            int actual;

            // act
            testList1 = testList1 - testList2;
            actual = testList1.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubtractionOperator_TwoListsShareNoSameValues_ListRemainsTheSame()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();

            testList1.Add(1);
            testList2.Add(2);

            int expected = 1;
            int actual;

            // act
            testList1 = testList1 - testList2;
            actual = testList1[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubtractionOperator_TwoListsOfStrings_ListRemainsTheSame()
        {
            // arrange
            CustomList<string> testList1 = new CustomList<string>();
            CustomList<string> testList2 = new CustomList<string>();

            testList1.Add("hello");
            testList1.Add("world");
            testList2.Add("world");

            string expected = "hello";
            string actual;

            // act
            testList1 = testList1 - testList2;
            actual = testList1[0];

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
