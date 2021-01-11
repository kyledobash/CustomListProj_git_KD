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
            CustomList<int> testList3 = new CustomList<int>();

            int expected = 4;
            int actual;
            
            // act
            testList1.Add(1);
            testList1.Add(3);
            testList2.Add(2);
            testList2.Add(4);            
            testList3 = testList1.Zip(testList2);
            actual = testList3.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_ZipTwoListsCheckSequence_ItemAtIndex2Is3()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testList3 = new CustomList<int>();
            testList1.Add(1);
            testList1.Add(3);
            testList2.Add(2);
            testList2.Add(4);


            int expected = 3;
            int actual;

            // act
            testList3 = testList1.Zip(testList2);
            actual = testList3[2];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_ZipWithEmptyList_CountRemainsTwo()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> emptyList = new CustomList<int>();
            CustomList<int> resultList = new CustomList<int>();
            testList.Add(1);
            testList.Add(3);
            

            int expected = 2;
            int actual;

            // act
            resultList = testList.Zip(emptyList);
            actual = resultList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_ZipListOfStrings_ItemAtIndex2IsHELLO()
        {
            // arrange
            CustomList<string> testList1 = new CustomList<string>();
            CustomList<string> testList2 = new CustomList<string>();
            CustomList<string> testList3 = new CustomList<string>();

            testList1.Add("hello");
            testList1.Add("HELLO");
            testList2.Add("world");
            testList2.Add("WORLD");


            string expected = "HELLO";
            string actual;

            // act
            testList3 = testList1.Zip(testList2);
            actual = testList3[2];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_ZipOneSmallAndOneLargeList_CountIs8()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testList3 = new CustomList<int>();

            testList1.Add(1);
            testList2.Add(2);
            testList2.Add(3);
            testList2.Add(4);
            testList2.Add(5);
            testList2.Add(6);
            testList2.Add(7);

            int expected = 7;
            int actual;

            // act
            testList3 = testList1.Zip(testList2);
            actual = testList3.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_ZipOneSmallAndOneLargeList_StringsAreEqual()
        {
            // arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> testList3 = new CustomList<int>();

            testList1.Add(1);
            testList2.Add(2);
            testList2.Add(3);
            testList2.Add(4);
            testList2.Add(5);
            testList2.Add(6);
            testList2.Add(7);

            string expected = "1234567";
            string actual;

            // act
            testList3 = testList1.Zip(testList2);
            actual = testList3.ToString();

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
