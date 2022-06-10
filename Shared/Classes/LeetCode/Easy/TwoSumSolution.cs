using System.Collections.Generic;

namespace Learning.Shared.Classes.LeetCode.Easy {
    public class TwoSumSolution {
        private Dictionary<int, int> memory = new Dictionary<int, int>();

        public int[] FindIfTwoComplementsExist(int[] numbers, int target) {
            for (int idx = 0; idx < numbers.Length; idx++) {
                int compliment = target - numbers[idx];

                if (memory.ContainsKey(numbers[idx])) {
                    return new int[] { memory[numbers[idx]], idx };
                }

                memory[compliment] = idx;
            }

            return new int[] { -1, -1 };
        }
    }
}