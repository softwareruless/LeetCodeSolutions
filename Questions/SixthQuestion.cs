
namespace LeetCodeSolutions
{
    public class SixthQuestion
    {
        public SixthQuestion()
        {
            var result = Convert("PAYPALISHIRING", 3);
            //var result = Convert("A", 1);
            //var result = Convert("PAYPALISHIRING", 4);

            Console.WriteLine(result);
        }

        private string Convert(string s, int numRows)
        {
            if (numRows == 1 || numRows >= s.Length)
                return s;

            var chars = new string[numRows];

            int sequence = 0;
            int direction = 1;

            for (int i = 0; i < s.Length; i++)
            {
                chars[sequence] += s[i];

                sequence += direction;

                if (sequence == 0 || sequence == numRows - 1)
                    direction *= -1;
            }

            return string.Concat(chars);
        }
    }
}

