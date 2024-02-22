namespace LeetCodeSolutions
{
    public class FifthQuestion
    {
        public FifthQuestion()
        {
            var result = LongestPalindrome("babad");
            //var result = LongestPalindrome("bb");
            //var result = LongestPalindrome("cbbd");
            //var result = LongestPalindrome("a");

            Console.WriteLine(result);
        }

        //My new faster solution: 
        //It check substrings by expand from Center and check chars are they equal to opposite side
        //I used ExpandAroundCenter(s, i, i) for palindrome of odd number length. fe => "aba" it checks "b" b = b. and "a" = "a".
        //I used ExpandAroundCenter(s, i, i + 1) for palindrome of odd number length. fe => "abba" it checks "b" = "b" and "a" = "a".

        private string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
                return "";

            int start = 0, end = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int len1 = ExpandAroundCenter(s, i, i);
                int len2 = ExpandAroundCenter(s, i, i + 1);
                int len = Math.Max(len1, len2);

                if (len > end - start)
                {
                    start = i - (len - 1) / 2;
                    end = i + len / 2;
                }
            }

            return s.Substring(start, end - start + 1);
        }

        private int ExpandAroundCenter(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }
            return right - left - 1;
        }

        //MyOldSolution was getting time exceeded error and I get help from AI.

        //private string LongestPalindrome(string s)
        //{
        //    var longestPalindrom = "";
        //    var k = 1;
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        for (int j = k; j <= s.Length - i; j++)
        //        {
        //            var substring = s.Substring(i, j);
        //            if (substring == new string(substring.Reverse().ToArray()))
        //            {
        //                if (substring.Length > longestPalindrom.Length)
        //                {
        //                    longestPalindrom = substring;
        //                    k = j + 1;
        //                }
        //            }
        //        }
        //    }
        //    return longestPalindrom;
        //}
    }
}

