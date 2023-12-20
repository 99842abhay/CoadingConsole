using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingConsole.Arrays
{
    public class FindMax
    {
        public static int FindMaxNumber(int[] nums)
        {
            int max = nums[0];
            for(int i=1; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }
            return max;
        }
    }
}
