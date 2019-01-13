using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoSum;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum.Tests
{
    [TestClass()]
    public class Leetcode001Tests
    {
        [TestMethod()]
        public void TwoSumTest()
        {
            int[] expectedValue;
            int[] inputValue;
            int[] resultValue;

            expectedValue = new int[] { 0, 1 };
            inputValue = new int[] { 2, 7, 11, 15 };
            resultValue = Leetcode001.TwoSum(inputValue, 9);
            Assert.IsTrue(expectedValue[0] == resultValue[0] && expectedValue[1] == resultValue[1]);

            expectedValue = new int[] { 1, 2 };
            inputValue = new int[] { 1, 7, 2, 15 };
            resultValue = Leetcode001.TwoSum(inputValue, 9);
            Assert.IsTrue(expectedValue[0] == resultValue[0] && expectedValue[1] == resultValue[1]);

            expectedValue = new int[] { 0, 4 };
            inputValue = new int[] { 2, 17, 11, 15, 7 };
            resultValue = Leetcode001.TwoSum(inputValue, 9);
            Assert.IsTrue(expectedValue[0] == resultValue[0] && expectedValue[1] == resultValue[1]);

            expectedValue = null;
            inputValue = null;
            resultValue = Leetcode001.TwoSum(inputValue, 9);
            Assert.IsTrue(expectedValue == resultValue);

            expectedValue = null;
            inputValue = new int[] { 0 };
            resultValue = Leetcode001.TwoSum(inputValue, 9);
            Assert.IsTrue(expectedValue == resultValue);

            //Assert.AreEqual(expectedValue, Leetcode001.TwoSum(inputValue, 9));
        }
    }
}