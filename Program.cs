using System;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 5, 0, 14, 400, 64 };
            sortBigtoSmall(nums);
            sortSmalltoBig(nums);
        }

        public static void sortBigtoSmall(int[] nums)
        {
            int[] temp = new int[nums.Length];
            int counter = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = 0; j < nums.Length; j++)
                {
                    if(nums[i] > nums[j])
                    {
                        counter++;
                    }
                }
                temp[counter] = nums[i];
                counter = 0;
            }
            Console.WriteLine("[{0}]", string.Join(", ", temp));
        }

        public static void sortSmalltoBig(int[] nums)
        {
            int[] temp = new int[nums.Length];
            int counter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        counter++;
                    }
                }
                temp[counter] = nums[i];
                counter = 0;
            }
            Console.WriteLine("[{0}]", string.Join(", ", temp));
        }
    }
}
