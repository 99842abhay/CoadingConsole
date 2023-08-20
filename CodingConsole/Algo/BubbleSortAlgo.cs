using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingConsole.Algo
{
    public class BubbleSortAlgo
    {
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;

            for(int pass = n - 1; pass >= 0; pass--)
            {
                for(int i=0; i<pass; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
            }

            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
        }

        public static void BubbleSort1(int[] arr)
        {
            int n = arr.Length;
            bool swapRequired = false;
            for (int i=0; i < n - 1; i++)
            {
                for(int j=0; j < n-i-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j+1] = temp;
                        swapRequired = true;
                    }
                }
                if (swapRequired == false)
                    break;
            }

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
