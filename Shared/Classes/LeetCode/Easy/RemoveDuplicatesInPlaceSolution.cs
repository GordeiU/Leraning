namespace Learning.Shared.Classes.LeetCode.Easy {
    /// <summary>
    /// Class <c>RemoveDuplicatesInPlaceSolution</c> Solution to the: https://leetcode.com/problems/remove-duplicates-from-sorted-array/
    /// </summary>
    public class RemoveDuplicatesInPlaceSolution {
        public int RemoveDuplicates(int[] numbers) {
            int masterIdx = 0;

            for (int i = 0; i < numbers.Length; i++) {
                if (numbers[masterIdx] < numbers[i]) {
                    masterIdx++;
                    numbers[masterIdx] = numbers[i];
                }
            }

            return masterIdx + 1;
        }
    }
}