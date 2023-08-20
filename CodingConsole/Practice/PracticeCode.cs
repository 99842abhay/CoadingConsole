using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingConsole.Practice
{
    public class PracticeCode
    {
        public static void RemoveDuplicate(string str)
        {
            Dictionary<char, int>  dic = new Dictionary<char, int>();
            StringBuilder sb = new StringBuilder();
            List<int> list = new List<int>();
            foreach (char c in str)
            {
                if (dic.ContainsKey(c))
                {
                    dic[c]++;
                }
                else
                {
                    dic[c] = 1;
                    sb.Append(c);
                }
            }

            foreach (var item in dic)
            {
                Console.WriteLine($"Key : {item.Key} -> Value : {item.Value}");
            }

            Console.WriteLine($" Removed Duplicate stirng : {sb.ToString()}" );
        }
    }
}
