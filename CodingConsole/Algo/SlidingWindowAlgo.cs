using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingConsole.Algo
{
    public  class SlidingWindowAlgo
    {
        public int MaxSum(int[] arr, int k)
        {
            int n = arr.Length;

            if(n < k)
            {
                Console.WriteLine("Invalid");
                return -1;
            }

            int max_sum = 0;
            for(int i=0; i<k; i++)
            {
                //MAX_SUM += arr[i];
                max_sum = max_sum + arr[i];
            }

            int window_sum = max_sum;
            for(int i=k; i<n; i++)
            {
                window_sum = window_sum + arr[i] - arr[i - k];
                max_sum = Math.Max(max_sum, window_sum);
            }
            return max_sum;
        }
    }
}
