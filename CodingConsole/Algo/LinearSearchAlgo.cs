using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingConsole.Algo
{
    public class LinearSearchAlgo
    {
        // Worst case time complexity O(n)
        public static int LinearSearch(int[] arr, int key)
        {
            int length = arr.Length;
            int i = 0;
            while(i < length)
            {
                if (arr[i] == key)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }
    }
}
