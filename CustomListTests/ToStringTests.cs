using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListProj_actual_KD;

namespace CustomListTests
{
    [TestClass]
    class ToStringTests
    {
        [TestMethod]
        public void ToString_SingleItemArray_ConvertsIntToString ()
        {
            {
                // arrange
                CustomList<string> testList = new CustomList<string>();

                testList.Add(3);

                string expected = "3";
                string actual;

                // act           
                actual = testList.ToString(testList[0]);

                // assert
                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void ToString_SingleItemArray_ConvertsCharToString()
        {
            {
                // arrange
                CustomList<string> testList = new CustomList<string>();

                char testChar = "k"
                testList.Add(testChar);

                string expected = "k";
                string actual;

                // act           
                actual = testList.ToString(testChar);

                // assert
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
