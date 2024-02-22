using System;
namespace LeetCodeSolutions
{
    public class ThirdQuestion
    {
        public ThirdQuestion()
        {
            var result = LengthOfLongestSubstring("abcabcbb");
            //var result = LengthOfLongestSubstring("bbbbb");
            //var result = LengthOfLongestSubstring("pwwkew");
            //var result = LengthOfLongestSubstring("");
            //var result = LengthOfLongestSubstring(" ");

            Console.WriteLine(result);
        }

        private int LengthOfLongestSubstring(string s)
        {
            // Check if the length of the string is less than 2
            if (s.Length < 2)
            {
                return s.Length;
            }

            // Initialize variables
            int k = 0, maxLen = 0, count = 0;

            // Iterate through the string
            for (int i = 1; i < s.Length; i++)
            {
                // Check for repeating characters in the current substring
                for (int j = k; j < i; j++)
                {
                    if (s[i] == s[j])
                    {
                        k = j + 1;
                    }
                }

                // Update the current substring length
                count = i - k + 1;

                // Update the maximum length
                if (count > maxLen)
                {
                    maxLen = count;
                }
            }

            // Return the result
            return maxLen;
        }

        //private int LengthOfLongestSubstring(string s)
        //{

        //    int max = 0;

        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        for (int j = max + 1; j <= s.Length - i; j++)
        //        {
        //            string @char = s.Substring(i, j);

        //            bool getOut = false;

        //            for (int k = 0; k < j; k++)
        //            {
        //                if (@char.Count(s => s == @char[k]) > 1)
        //                {
        //                    getOut = true;
        //                    break;
        //                }
        //            }

        //            if (!getOut)
        //            {
        //                max = j;
        //            }
        //        }
        //    }

        //    return max;
        //}

    }
}

