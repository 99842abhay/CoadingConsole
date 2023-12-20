using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingConsole.Arrays
{
    public class MergeSortedArrayCode
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n) 
        {
            int index1 = m - 1;
            int index2 = n - 1;
            int mergedIndex = m + n - 1;

            while (index1 >= 0 && index2 >= 0)
            {
                if (nums1[index1] > nums2[index2])
                {
                    nums1[mergedIndex] = nums1[index1];
                    index1--;
                }
                else
                {
                    nums1[mergedIndex] = nums2[index2];
                    index2--;
                }
                mergedIndex--;
            }

            // If there are remaining elements in nums2, they are already sorted
            while (index2 >= 0)
            {
                nums1[mergedIndex] = nums2[index2];
                index2--;
                mergedIndex--;
            }
        }
    }
}
