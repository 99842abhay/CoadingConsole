using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingConsole.Arrays
{
    public class _3SumCode
    {
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();

            Array.Sort(nums);// Sort the array to handle duplicates

            for(int i=0; i < nums.Length-2 ; i++)
            {
                // Skip duplicate values for the first element of the triplet
                if (i > 0 && nums[i] == nums[i - 1]) continue;

                int left = i + 1;
                int right  = nums.Length - 1;

                while(left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];
                    if(sum == 0)
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });
                        //Skip Duplicate values for the second element fo the triplet
                        while (left < right && nums[left] == nums[left + 1]) left++;

                        //skip duplicate values for the third element of the triplet
                        while(left < right && nums[right] == nums[right - 1]) right--;

                        left++;
                        right--;
                    }
                    else if (sum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
            return result;
        }
    }
}
