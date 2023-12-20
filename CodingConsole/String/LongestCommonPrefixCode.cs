using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingConsole.String
{
    public class LongestCommonPrefixCode
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            if(strs.Length == 0 && strs.Length == null)
            {
                return "";
            }
            string prefix = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                int j = 0;

                while (j < prefix.Length && j < strs[i].Length && prefix[j] == strs[i][j]) 
                {
                    j++;
                }

                // Update the prefix based on the comparison
                prefix = prefix.Substring(0, j);

                // If prefix becomes empty, no need to check further
                if (prefix == "")
                {
                    break;
                }

            }
            return prefix;
        }
    }
}
