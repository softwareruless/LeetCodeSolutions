namespace LeetCodeSolutions
{
    public class FirstQuestion
    {
        public FirstQuestion()
        {
            var result = TwoSum(new int[3] { 3, 2, 4 }, 6);

            Console.WriteLine(result);
        }

        private int[] TwoSum(int[] nums, int target)
        {
            int[] array = new int[2];
            bool finished = false;
            for (int i = 0; i < nums.Length; i++)
            {

                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    var total = nums[i] + nums[j];

                    if (total == target)
                    {
                        array[0] = i;
                        array[1] = j;
                        finished = true;
                        break;
                    }
                }

                if (finished)
                {
                    break;
                }

            }

            return array;
        }
    }
}