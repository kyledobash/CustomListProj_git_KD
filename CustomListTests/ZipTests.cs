using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListProj_actual_KD;

namespace CustomListTests
{
    [TestClass]
    public class ZipTests
    {
        [TestMethod]
        public void Zip_ZipTwoListsWithTwoItemsEach_CountIs4()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();

            int expected = 4;
            int actual;
            
            // act
            testList1.Add(1);
            testList1.Add(3);
            testList2.Add(2);
            testList2.Add(4);            
            testList1.Zip(testList2);
            actual = testList1.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_ZipTwoListsCheckSequence_ItemAtIndex2Is3()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            testList1.Add(1);
            testList1.Add(3);
            testList2.Add(2);
            testList2.Add(4);


            int expected = 3;
            int actual;

            // act
            testList1.Zip(testList2);
            actual = testList1[2];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_ZipWithEmptyList_CountRemainsTwo()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> emptyList = new CustomList<int>();
            testList.Add(1);
            testList.Add(3);
            

            int expected = 0;
            int actual;

            // act
            testList.Zip(emptyList);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_ZipListOfStrings_ItemAtIndex2IsHELLO()
        {
            // arrange
            CustomList<string> testList1 = new CustomList<string>();
            CustomList<string> testList2 = new CustomList<string>();
            testList1.Add("hello");
            testList1.Add("HELLO");
            testList2.Add("world");
            testList2.Add("WORLD");


            string expected = "HELLO";
            string actual;

            // act
            testList1.Zip(testList2);
            actual = testList1[2];

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
