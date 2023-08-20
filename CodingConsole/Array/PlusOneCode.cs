using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingConsole.Array
{
    public class PlusOneCode
    {
        /*
         
         Input: digits = [1,2,3]
         Output: [1,2,4]
         Explanation: The array represents the integer 123.
         Incrementing by one gives 123 + 1 = 124.
         Thus, the result should be [1,2,4].

         Input: digits = [9]
         Output: [1,0]
         Explanation: The array represents the integer 9.
         Incrementing by one gives 9 + 1 = 10.
         Thus, the result should be [1,0].
        */
        public int[] PlusOne(int[] digits)
        {
            int n = digits.Length;  

            for(int i = n-1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }

                digits[i] = 0;
            }

            int[] result = new int[n + 1];
            result[0] = 1;
            return result;
        }
    }
}
