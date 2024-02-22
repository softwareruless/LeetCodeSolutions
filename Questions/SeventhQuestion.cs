using System;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCodeSolutions
{
    public class SeventhQuestion
    {
        public SeventhQuestion()
        {
            Reverse(-123);
            Reverse(123);
            Reverse(-321);
            Reverse(1534236469);
            Reverse(120);
        }

        //Reverse numbers
        //Result should be Int32.
        //If reversed number is larger than Int32 return 0;
        private int Reverse(int x)
        {
            string value = x.ToString();
            bool isNegative = value.StartsWith("-");

            var reverse = new List<char>();

            for (int i = value.Length - 1; i >= (isNegative ? 1 : 0); i--)
            {
                reverse.Add(value[i]);
            }

            int response = 0;
            //If reversed number is larger than Int32 return 0;
            if (!int.TryParse(reverse.ToArray(), out response)) return 0;

            return isNegative ? -response : response;
        }
    }

}

