using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingConsole.Arrays
{
    public class CommonCharsCode
    {
        public static IList<string> CommonChars(string[] words)
        {
            //Initialize the character frequency dictionary with character from the first word
            
            Dictionary<char, int> charFreq = new Dictionary<char, int>();
            foreach (char c in words[0])
            {
                charFreq[c] = charFreq.ContainsKey(c) ? charFreq[c] + 1 : 1;
            }

            // Update character frequencies based on other words
            for(int i=0; i<words.Length; i++)
            {
                Dictionary<char, int> wordFreq = new Dictionary<char, int>();
                foreach (char c in words[i])
                {
                    wordFreq[c] = wordFreq.ContainsKey(c) ? wordFreq[c] + 1 : 1;
                }
                // Update charFreq based on wordFreq
                foreach (char key in charFreq.Keys.ToArray())
                {
                    if (wordFreq.ContainsKey(key))
                    {
                        charFreq[key] = Math.Min(charFreq[key], wordFreq[key]);
                    }
                    else
                    {
                        charFreq.Remove(key);
                    }
                }
            }

            // Convert charFreq to the result list
            List<string> result = new List<string>();
            foreach (char key in charFreq.Keys)
            {
                for (int i = 0; i < charFreq[key]; i++)
                {
                    result.Add(key.ToString());
                }
            }

            return result;
        }
    }
}
