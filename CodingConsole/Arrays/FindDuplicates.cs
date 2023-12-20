using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingConsole.Arrays
{
    public class FindDuplicates
    {
        public static List<int> PrintDuplicates(int[] arr)
        {
            List<int> duplicates = new List<int>();
            Dictionary<int, int> counts = new Dictionary<int, int>();
            foreach (int i in arr)
            {
                if (counts.ContainsKey(i))
                {
                    counts[i]++;
                }
                else
                {
                    counts[i] = 1; 
                }
            }

            foreach(KeyValuePair<int, int> pair in counts)
            {
                if(pair.Value == 1) {
                    duplicates.Add(pair.Key);
                }
            }

            return duplicates;
        }
    }
}
