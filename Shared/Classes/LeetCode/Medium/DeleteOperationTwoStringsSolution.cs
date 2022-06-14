using System;

namespace Learning.Shared.Classes.LeetCode.Medium {
    /// <summary>
    /// Class <c>DeleteOperationTwoStringsSolution</c> Solution to the: https://leetcode.com/problems/delete-operation-for-two-strings/
    /// </summary>
    public class DeleteOperationTwoStringsSolution {
        private int?[,]? memory;

        public int MinDistance(string wordOne, string wordTwo) {
            memory = new int?[wordOne.Length + 1, wordTwo.Length + 1];

            int longestSubsequenceCount = LongestStringSubsequence(wordOne, wordTwo);

            return wordOne.Length + wordTwo.Length - longestSubsequenceCount * 2;
        }

        private int LongestStringSubsequence(string wordOne, string wordTwo) {
            int wordOneLength = wordOne.Length;
            int wordTwoLength = wordTwo.Length;

            if (memory![wordOneLength, wordTwoLength] != null) {
                return memory[wordOneLength, wordTwoLength]!.Value;
            }

            int result;

            if (wordOneLength == 0 || wordTwoLength == 0) {
                result = 0;
            } else if (wordOne[wordOneLength - 1] == wordTwo[wordTwoLength - 1]) {
                return 1 + LongestStringSubsequence(
                    wordOne.Substring(0, wordOneLength - 1),
                    wordTwo.Substring(0, wordTwoLength - 1)
                );
            } else {
                result = Math.Max(
                    LongestStringSubsequence(wordOne, wordTwo.Substring(0, wordTwoLength - 1)),
                    LongestStringSubsequence(wordOne.Substring(0, wordOneLength - 1), wordTwo)
                );
            }

            memory[wordOneLength, wordTwoLength] = result;
            return result;
        }
    }
}