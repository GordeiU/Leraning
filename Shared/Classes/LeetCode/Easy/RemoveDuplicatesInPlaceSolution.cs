namespace Learning.Shared.Classes.LeetCode.Easy {
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