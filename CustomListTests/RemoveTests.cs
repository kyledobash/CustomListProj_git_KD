using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListProj_actual_KD;

namespace CustomListTests
{
    [TestClass]
    public class RemoveTests
    {
        [TestMethod]
        public void Remove_AttemptToRemoveBadValue_ReturnsFalse()
        {
            // arrange
            CustomList<string> testList = new CustomList<string>();

            bool expected = false;
            bool actual;

            testList.Add("this string will not be removed");

            // act           
            actual = testList.Remove("hello");

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveOnlyItemFromList_CountIs0()
        {
            // arrange
            CustomList<string> testList = new CustomList<string>();

            int expected = 0;
            int actual;

            string testString = "String to be removed";
            testList.Add(testString);

            // act
            testList.Remove(testString);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveMultipleItemsFromList_CountIs1()
        {
            // arrange
            CustomList<string> testList = new CustomList<string>();

            int expected = 1;
            int actual;

            string testString1 = "This string will remain";
            string testString2 = "This string will be removed";
            string testString3 = "This string will also be removed";
            testList.Add(testString1);
            testList.Add(testString2);
            testList.Add(testString3);

            // act
            testList.Remove(testString2);
            testList.Remove(testString3);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        // capacity tests

        [TestMethod]
        public void Remove_CheckDefaultCapacityEmptyArray_CapacityOf4()
        {
            // arrange
            CustomList<string> testList = new CustomList<string>();

            int expected = 4;
            int actual;

            // act
            actual = testList.Capacity;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveIndex3InArrayOf5Items_5thTestStringMovesToIndex3()
        {
            // arrange
            CustomList<string> testList = new CustomList<string>();

            string expected = "5th test string";
            string actual;

            testList.Add("1st test string");
            testList.Add("2nd test string");
            testList.Add("3rd test string");
            testList.Add("This string will be Removed");
            testList.Add("5th test string");

            // act
            testList.Remove(testList[3]);
            actual = testList[3];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveItemFromArrayOf2Items_1stItemRemainsAt0Index()
        {
            // arrange
            CustomList<string> testList = new CustomList<string>();

            string expected = "1st test string";
            string actual;

            testList.Add("1st test string");
            testList.Add("this string will be removed");

            // act
            testList.Remove(testList[1]);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        public void Remove_RemoveOnlyItemFromArray_CapacityRemains4()
        {
            // arrange
            CustomList<string> testList = new CustomList<string>();

            int expected = 4;
            int actual;

            testList.Add("this string will be removed");


            // act
            testList.Remove(testList[0]);
            actual = testList.Capacity;

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
