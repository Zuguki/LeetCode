﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace twoSum
{
    // Given an array of integers nums and an integer target, 
    // return indices of the two numbers such that they add up to target.

    // You may assume that each input would have exactly one solution, 
    // and you may not use the same element twice.

    // You can return the answer in any order.

    /* 
    Example 1
    
        Input: nums = [2,7,11,15], target = 9
        Output: [0,1]
        Output: Because nums[0] + nums[1] == 9, we return [0, 1].
    */

    /* 
    Example 2
        Input: nums = [3,2,4], target = 6
        Output: [1,2]
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintSolution(Solution.TwoSum(new int[] {2, 7, 11, 15}, 9));
            PrintSolution(Solution.TwoSum(new int[] {3, 2, 4}, 6));
            PrintSolution(Solution.TwoSum(new int[] {3, 3}, 6));
        }

        private static void PrintSolution(int[] indexes)
        {
            Console.WriteLine($"{indexes[0]} {indexes[1]}");
        }
    }

    public static class Solution 
    {
        public static int[] TwoSum(int[] nums, int target) 
        {
            var indexes = new int[2];

            for (var firstIndex = 0; firstIndex < nums.Length; firstIndex++)
            {
                var differenceWithTarget = target - nums[firstIndex];
                
                for (var secondIndex = firstIndex + 1; secondIndex < nums.Length; secondIndex++)
                {
                    if (nums[secondIndex] == differenceWithTarget)
                    {
                        indexes[0] = firstIndex;
                        indexes[1] = secondIndex;
                        break;
                    }
                }
            }

            return indexes;   
        }
    }
}
