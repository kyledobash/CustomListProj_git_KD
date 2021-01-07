using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListProj_actual_KD;

namespace CustomListTests
{
    [TestClass]
    public class ToStringTests
    {
        [TestMethod]
        public void ToString_SingleItemArray_ConvertsIntToString()
        {
            {
                // arrange
                CustomList<int> testList = new CustomList<int>();

                testList.Add(3);

                string expected = "3";
                string actual;

                // act           
                actual = testList[0].ToString();

                // assert
                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void ToString_SingleItemArray_ConvertsCharToString()
        {
            {
                // arrange
                CustomList<char> testList = new CustomList<char>();

                char testChar = 'k';
                testList.Add(testChar);

                string expected = "k";
                string actual;

                // act           
                actual = testList[0].ToString();

                // assert
                Assert.AreEqual(expected, actual);
            }
        }
    }
}