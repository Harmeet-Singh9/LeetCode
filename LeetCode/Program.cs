using System;
using System.Collections.Generic;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Leetcode_1_Two_Sum
    {
        public Leetcode_1_Two_Sum()
        {
            Console.WriteLine("Hello");
        }
        public int[] TwoSum(int[] nums, int target)
        {
            if (nums == null || nums.Length < 2)
                return new int[0];

            var visited = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var current = nums[i];
                var search = target - current;

                if (visited.ContainsKey(search))
                {
                    return new int[] { visited[search], i };
                }
                else
                {
                    if (!visited.ContainsKey(current))
                    {
                        visited.Add(current, i);
                    }
                }
            }

            return new int[0];
        }
    }
}
