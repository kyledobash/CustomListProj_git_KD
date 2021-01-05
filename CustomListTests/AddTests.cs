using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListProj_actual_KD;

namespace CustomListTests
{
    [TestClass]
    public class AddTests
    {
        [TestMethod]
        public void Add_AddItemToEmptyList_CountIs1 ()
        {
            // arrange
            CustomList<string> testList = new CustomList<string>();

            int expected = 1;
            int actual;

            string testString = "This should add to testList";

            // act
            testList.Add(testString);
            actual = testList.count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddItemToEmptyList_ItemAt0Index()
        {
            // arrange
            CustomList<string> testList = new CustomList<string>();

            string expected = "This should add to testList";
            string actual;

            string testString = "This should add to testList";

            // act
            testList.Add(testString);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddMultipleItemsToList_CountIs3()
        {
            // arrange
            CustomList<string> testList = new CustomList<string>();

            int expected = 3;
            int actual;

            string testString1 = "1st test string";
            string testString2 = "2nd test string";
            string testString3 = "3rd test string";

            // act
            testList.Add(testString1);
            testList.Add(testString2);
            testList.Add(testString3);
            actual = testList.count;

            // assert
            Assert.AreEqual(expected, actual);
        }

            // capacity tests

        [TestMethod]
        public void Add_CheckDefaultCapacityEmptyArray_CapacityOf4()
        {
            // arrange
            CustomList<string> testList = new CustomList<string>();

            int expected = 4;
            int actual;
            
            // act
            actual = testList[0].capacity;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddItemToArrayOf4Items_CapacityDoubles()
        {
            // arrange
            CustomList<string> testList = new CustomList<string>();

            int expected = 8;
            int actual;

            string testString1 = "1st test string";
            string testString2 = "2nd test string";
            string testString3 = "3rd test string";
            string testString4 = "4th test string";
            string testString5 = "5th test string";

            // act
            testList.Add(testString1);
            testList.Add(testString2);
            testList.Add(testString3);
            testList.Add(testString4);
            testList.Add(testString5);
            actual = testList[4].capacity;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddItemToArrayOf1Item_OriginalItemRemainsAtIndex0 ()
        {
            // arrange
            CustomList<string> testList = new CustomList<string>();

            string expected = "1st test string";
            string actual;

            string testString1 = "1st test string";
            string testString2 = "2nd test string";
            
            // act
            testList.Add(testString1);
            testList.Add(testString2);
            
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        public void Add_AddItemToArrayOf4Items_LastItemAtIndex4()
        {
            // arrange
            CustomList<string> testList = new CustomList<string>();

            string expected = "4th test string";
            string actual;

            string testString1 = "1st test string";
            string testString2 = "2nd test string";
            string testString3 = "3rd test string";
            string testString4 = "4th test string";
            string testString5 = "5th test string";

            // act
            testList.Add(testString1);
            testList.Add(testString2);
            testList.Add(testString3);
            testList.Add(testString4);
            testList.Add(testString5);
            actual = testList[4];

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
