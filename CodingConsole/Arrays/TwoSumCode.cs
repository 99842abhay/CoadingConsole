using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CodingConsole.Arrays
{
    public class TwoSumCode
    {
        //int[] nums = { 2, 7, 11, 15 };
        //int target = 9;
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            
            for(int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                // Check if the complement exists in the dictionary
                if (dict.ContainsKey(complement))
                {
                    // If found, return the indices of the current number and its complement
                    return new int[] { dict[complement], i };
                }

                // Add current number and its index to the dictionary
                if (!dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]] = i;
                }
            }
            // Return an empty array if no solution is found
            return new int[0];
        }
    }
}
