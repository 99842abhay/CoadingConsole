using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingConsole.Algo
{
    public class BinarySearchAlgo
    {
        // BInary Search will work only when the array is in sorted Order .. So we will start with the Middel element  O(log n)
        public static int BinarySearch(int[] arr, int key)
        {
            int start = 0;
            int end = arr.Length - 1;
            while (start <= end)
            {
                int mid =  (start + end) / 2;
                if (arr[mid] == key)
                {
                    return mid;
                }
                else if (key < arr[mid])
                {
                    end = mid - 1;
                }
                else if (key > arr[mid])
                {
                    start = mid + 1;
                }
            }
            return -1;
        }
    }
}
