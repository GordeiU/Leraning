namespace Learning.Shared.Classes.LeetCode.Easy {
    /// <summary>
    /// Class <c>RemoveDuplicateElementInPlaceSolution</c> Solution to the: https://leetcode.com/problems/remove-element/
    /// </summary>
    public class RemoveDuplicateElementInPlaceSolution {
        public int RemoveElement(int[] numbers, int val) {
            int masterIdx = 0;

            for (int idx = 0; idx < numbers.Length; idx++) {
                if (numbers[idx] != val) {
                    numbers[masterIdx] = numbers[idx];
                    masterIdx++;
                }
            }

            return masterIdx;
        }
    }
}