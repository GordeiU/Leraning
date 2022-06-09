namespace Learning.Shared.Classes.LeetCode.Easy {
    public static class LongestCommonPrefixSolution {
        public static string FindLongestCommonPrefix(string[] words) {
            int stringLength = words[0].Length;
            string result = string.Empty;
            char buffer;

            for (int letterIdx = 0; letterIdx < stringLength; letterIdx++) {
                buffer = words[0][letterIdx];

                for (int wordIdx = 1; wordIdx < words.Length; wordIdx++) {
                    if (words[wordIdx].Length <= letterIdx) goto ReturnResult;

                    if (words[wordIdx][letterIdx] != buffer) goto ReturnResult;
                }

                result += buffer;
            }

        ReturnResult:
            return result;
        }
    }
}