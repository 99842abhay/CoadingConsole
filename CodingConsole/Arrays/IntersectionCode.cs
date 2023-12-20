using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingConsole.Arrays
{
    public class IntersectionCode
    {
        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();

            foreach(int x in nums1)
            {
                set1.Add(x);
            }

            foreach(int x in nums2)
            {
                if (set1.Contains(x))
                {
                    set2.Add(x);
                }
            }

            int[] result = set2.ToArray();

            return result;
        }

        public static int[] IntersectionII(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> freqMap = new Dictionary<int, int>();
            List<int> result = new List<int>();

            // Populate the frequency map for nums1
            foreach (int x in nums1)
            {
                if (freqMap.ContainsKey(x))
                {
                    freqMap[x]++;
                }
                else
                {
                    freqMap[x] = 1;
                }
            }

            // Check the frequency map for nums2 and add to the result
            foreach(int x in nums2)
            {
                if(freqMap.ContainsKey(x) && freqMap[x] > 0)
                {
                    result.Add(x);
                    freqMap[x]--;
                }
            }

            return result.ToArray();
        }
    }
}
