using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListProj_actual_KD;

namespace CustomListTests
{
    [TestClass]
    public class CustomIteratorTests
    {
        [TestMethod]
        public void GetEnumator_ClonesAList_CountIs4()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();

            int expected = 4;
            int actual;

            // act
            testList1.Add(1);
            testList1.Add(3);
            testList1.Add(2);
            testList1.Add(4);
            
            foreach (int item in testList1)
            {
                testList2.Add(item);
            }

            actual = testList2.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetEnumator_AccessesEveryItemTurnsToString_StringsAssertEqual()
        {
            // arrange
            CustomList<string> testList1 = new CustomList<string>();
            CustomList<string> testList2 = new CustomList<string>();

            string expected = "This is a test ";
            string actual;

            // act
            testList1.Add("This");
            testList1.Add("is");
            testList1.Add("a");
            testList1.Add("test ");

            foreach (string item in testList1)
            {
                actual = actual + item.ToString() + " ";
            }
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetEnumator_IterateEmptyString_NumberOfIterationsIs0()
        {
            // arrange
            CustomList<string> testList1 = new CustomList<string>();

            int expected = 0;
            int actual;

            // act
            foreach (string item in testList1)
            {
                actual++;
            }
            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
