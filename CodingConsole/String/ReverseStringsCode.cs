using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingConsole.String
{
    public class ReverseStringsCode
    {
        public static void ReverseCompleteString(string str)
        {
            char[] chArr = str.ToCharArray();
            int start = 0;
            int end = str.Length - 1;

            while(start < end)
            {
                char temp = chArr[start];
                chArr[start] = chArr[end];
                chArr[end] = temp;
                start++;
                end--;
            }

            string reversedString = new string(chArr);
            Console.WriteLine(reversedString);
        }

        public static void ReverseEachWord(string str)
        {
            #region Using Built - in functions
            //string[] words = str.Split(' ');
            //Array.Reverse(words);
            //string output = string.Join(" ", words);
            //Console.WriteLine(output);
            #endregion

            // Without Using buit in functions 
            // Input : Hello How are you, Output :  you are How Hello
            //int i;
            //StringBuilder sb = new StringBuilder(); 
            //int start = str.Length - 1;
            //int end = str.Length - 1;

            //while(start > 0) {
            //    if (str[start] == ' ') {
            //        i = start + 1;
            //        while( i  <= end)
            //        {
            //            sb.Append(str[i]);
            //            i++;
            //        }
            //        sb.Append(' ');
            //        end = start - 1;
            //    }
            //    start--;
            //}

            //for(i=0; i<=end; i++)
            //{
            //    sb.Append(str[i]);
            //}

            //Console.Write(sb.ToString());

            char[] chars = str.ToCharArray();
            Reverse(chars, 0, chars.Length - 1); // first reverse the entier array 

            // after reverse the indivisual words in the caharacter array ;
            int start = 0;
            for(int i= 0; i <= chars.Length; i++)
            {
                if(i==chars.Length || chars[i] == ' ')
                {
                    Reverse(chars, start, i - 1);
                    start = i + 1;
                }
            }

            string output = new string(chars);
            Console.WriteLine(output);

        }
        static void Reverse(char[] chars, int start, int end)
        {
            while (start < end)
            {
                char temp = chars[start];
                chars[start] = chars[end];
                chars[end] = temp;
                start++;
                end--;
            }
        }
    }
}
