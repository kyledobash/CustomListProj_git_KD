using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListProj_actual_KD;

namespace CustomListTests
{
    [TestClass]
    public class SortTests
    {
        [TestMethod]
        public void Sort_SortListofIntsContainingDuplicates_SortsDuplicates()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();

            string expected = "1122345";
            string actual;

            testList.Add(1);
            testList.Add(2);
            testList.Add(1);
            testList.Add(2);
            testList.Add(5);
            testList.Add(4);
            testList.Add(3);

            // act
            testList.Sort();
            actual = testList.ToString();

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
