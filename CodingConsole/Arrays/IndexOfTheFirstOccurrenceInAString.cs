using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingConsole.Arrays
{
    public class IndexOfTheFirstOccurrenceInAString
    {
        public static int FindFirstOccurance(string haystack, string needle)
        {
            int n = haystack.Length;
            int m = needle.Length;  

            if(m == 0)
            {
                return 0;
            }
            if(n < m)
            {
                return -1;
            }

            for (int i = 0; i <= n - m; i++)
            {
                int j;
                for (j = 0; j < m; j++)
                {
                    if (haystack[i + j] != needle[j])
                    {
                        break; // Mismatch found, break the loop.
                    }
                }
                if (j == m)
                {
                    return i; // Match found, return the starting index.
                }
            }
            return -1; // Needle not found in haystack.
        }
    }
}
