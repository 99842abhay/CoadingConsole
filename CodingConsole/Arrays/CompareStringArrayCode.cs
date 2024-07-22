using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingConsole.Arrays
{
    public class CompareStringArrayCode
    {
        // this is the code without using inbuilt method;
        public static bool CompareArrayString(string[] arr1, string[] arr2)
        {
            int index1= 0, index2=0;
            int charIndex1 = 0, charIndex2 = 0;

            while(index1 < arr1.Length && index2 < arr2.Length)
            {
                if (arr1[index1][charIndex1] != arr2[index2][charIndex2])
                {
                    return false;
                }

                 charIndex1++;
                if(charIndex1 == arr1[index1].Length)
                {
                    charIndex1 = 0;
                    index1++;
                }

                charIndex2++;
                if(charIndex2 == arr2[index2].Length)
                {
                    charIndex2 = 0;
                    index2++;
                }
            }
            return index1 == arr1.Length && index2 == arr2.Length;
        }

        //Code with in built method 
        public static bool CompareArrayString1(string[] arr1, string[] arr2)
        {
            string str1 = string.Concat(arr1);
            string str2 = string.Concat(arr2);

            if (str1 == str2)
            {
                return true;
            }
            return false;
        }
    }
}
