using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CombineIntArrays;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void EmptyArray1()
        {
            int[] array1 = new int[]{};
            int[] array2 = new int[]{1, 2, 8, 4, 5};
            int[] expected = new int[]{1, 2, 8, 4, 5};
            CollectionAssert.AreEqual(expected, Program.CombineIntegersArray(array1, array2));
        }

        [TestMethod]
        public void EmptyArray2()
        {
            int[] array1 = new int[] {1, 0, -20, -150};
            int[] array2 = new int[] {};
            int[] expected = new int[] { 1, 0, -20, -150 };
            CollectionAssert.AreEqual(expected, Program.CombineIntegersArray(array1, array2));
        }

        [TestMethod]
        public void TwoPositiveIntArrays()
        {
            int[] array1 = new int[] { 1, 2, 1};
            int[] array2 = new int[] { 1, 2, 8, 4, 5 };
            int[] expected = new int[] { 1, 2, 1, 1, 2, 8, 4, 5 };
            CollectionAssert.AreEqual(expected, Program.CombineIntegersArray(array1, array2));
        }
    }
}
