using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingConsole.Arrays
{
    public class RemoveElementCode
    {
        public static int RemoveElement(int[] nums, int val)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                if (nums[left] == val)
                {
                    nums[left] = nums[right];
                    right--;
                }
                else
                {
                    left++;
                }
            }
            return left;
        }
    }
}
