using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingConsole.String
{
    internal class Demo
    {
        public static void ReverseSentence(string str)
        {
            StringBuilder sb = new StringBuilder();
            int start = str.Length - 1;
            int end = str.Length - 1;
            int i;
            while(start > 0)
            {
                if (str[start] == ' ')
                {
                    i = start + 1;
                    while(i <= end)
                    {
                        sb.Append(str[i]);
                        i++;
                    }
                    sb.Append(' ');
                    end = start - 1;
                }
                start--;
            }
        }
    }
}
