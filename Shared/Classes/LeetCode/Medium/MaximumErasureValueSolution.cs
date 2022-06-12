using System.Collections.Generic;

namespace Learning.Shared.Classes.LeetCode.Medium {
    /// <summary>
    /// Class <c>MaximumErasureValueSolution</c> Solution to the: https://leetcode.com/problems/maximum-erasure-value/
    /// </summary>
    public class MaximumErasureValueSolution {
        public int MaximumUniqueSubArray(int[] numbers) {
            HashSet<int> memory = new HashSet<int>();
            int startIdx = 0;
            int intermediateHighest = 0;
            int highest = intermediateHighest;

            for (int idx = 0; idx < numbers.Length; idx++) {
                while (memory.Contains(numbers[idx])) {
                    intermediateHighest -= numbers[startIdx];
                    memory.Remove(numbers[startIdx]);
                    startIdx++;
                }

                memory.Add(numbers[idx]);
                intermediateHighest += numbers[idx];

                if (intermediateHighest > highest) {
                    highest = intermediateHighest;
                }
            }

            return highest;
        }
    }
}