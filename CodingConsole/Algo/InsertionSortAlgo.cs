using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingConsole.Algo
{
    public class InsertionSortAlgo
    {
        public static void InsertionSort(int[] arr)
        {
            int n  = arr.Length;
            for(int i=1; i < n; i++)
            {
                int temp = arr[i];
                int position = i;
                while(position > 0 && arr[position - 1] > temp)
                {
                    arr[position] = arr[position - 1];
                    position--;
                }
                arr[position] = temp;
            }

            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
