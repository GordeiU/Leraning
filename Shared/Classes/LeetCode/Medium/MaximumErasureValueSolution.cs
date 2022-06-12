using System.Collections.Generic;

namespace Learning.Shared.Classes.LeetCode.Medium {
    /// <summary>
    /// Class <c>MaximumErasureValueSolution</c> Solution to the: https://leetcode.com/problems/maximum-erasure-value/
    /// </summary>
    public class MaximumErasureValueSolution {
        public int HighestScore { get; private set; }

        public int MaximumUniqueSubArray(int[] numbers) {
            Dictionary<int, int> memory = new Dictionary<int, int>();
            int intermediateHighest = 0;
            int highest = intermediateHighest;

            for (int idx = 0; idx < numbers.Length; idx++) {
                if (memory.ContainsKey(numbers[idx])) {
                    intermediateHighest = 0;

                    idx = memory[numbers[idx]];
                    memory.Clear();

                    continue;
                } else {
                    memory[numbers[idx]] = idx;
                }

                intermediateHighest += numbers[idx];

                if (intermediateHighest > highest) {
                    highest = intermediateHighest;
                }
            }

            return highest;
        }
    }
}