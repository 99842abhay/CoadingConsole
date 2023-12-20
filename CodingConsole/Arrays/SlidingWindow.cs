using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingConsole.Arrays
{
    public class SlidingWindow
    {
        public static int FindMaxSumSubArray(int[] arr, int k)
        {
            int n = arr.Length;

            int max_sum = 0;

            for(int i=0; i < k; i++)
            {
                max_sum += arr[i];  
            }

            int window_sum = 0;

            for(int i = k; i<n; i++)
            {
                window_sum += arr[i] - arr[i - k];
                //max_sum = Math.Max(max_sum, window_sum);
                if(window_sum > max_sum)
                {
                    max_sum = window_sum;
                }
            }
            return max_sum;
        }

        public static int LengthOfLongestSubstring(string str)
        {
            int n = str.Length;
            int max_len = 0;
            int left = 0;
            int right = 0;  

            HashSet<char> chars = new HashSet<char>();  
            
            while(right < n)
            {
                char currentChar = str[right];
                if(!chars.Contains(currentChar))
                {
                    chars.Add(currentChar);
                    max_len = Math.Max(max_len, right - left + 1);
                    right++;
                }
                else
                {
                    chars.Remove(str[left]);
                    left++;
                }
            }
            return max_len;
        }
    }
}
