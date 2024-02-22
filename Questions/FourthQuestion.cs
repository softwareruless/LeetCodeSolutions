namespace LeetCodeSolutions
{
    public class FourthQuestion
    {
        public FourthQuestion()
        {
            var result = FindMedianSortedArrays(new int[] { 1, 3 }, new int[] { 2 });
            //var result = FindMedianSortedArrays(new int[] { 1, 2 }, new int[] { 3, 4 });
            //var result = FindMedianSortedArrays(new int[] { 1, 1 }, new int[] { 1, 2 });
            Console.WriteLine(result);
        }

        private double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {

            int[] commonArray = new int[nums1.Length + nums2.Length];
            Array.Copy(nums1, commonArray, nums1.Length);
            Array.Copy(nums2, 0, commonArray, nums1.Length, nums2.Length);
            Array.Sort(commonArray);

            var length = commonArray.Count();

            var response = 0.0;

            if (length % 2 == 0)
            {
                double firstElement = commonArray[(length / 2) - 1];
                double secondElement = commonArray[length / 2];
                response = (firstElement + secondElement) / 2;
            }
            else
            {
                response = commonArray[(int)((length / 2) + 0.5)];
            }

            return response;
        }
    }
}