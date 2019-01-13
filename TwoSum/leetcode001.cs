using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    public class Leetcode001
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] returnValue = null;
            if(nums==null)
                return returnValue;

            if (nums.Length < 2)
                return returnValue;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (j != i)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            returnValue = new int[] { i, j };
                            return returnValue;
                        }
                    }
                }
            }
            return returnValue;
        }
    }
}
