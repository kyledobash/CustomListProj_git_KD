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
            actual = testList.Count;

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
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
