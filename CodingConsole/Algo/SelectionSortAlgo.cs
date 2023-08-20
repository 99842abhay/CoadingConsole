using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingConsole.Algo
{
    public class SelectionSortAlgo
    {
        // this is Unstable Algo with O(n2) complexity 
        public static void SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int position = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[position])
                    {
                        position = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[position];
                arr[position] = temp;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
