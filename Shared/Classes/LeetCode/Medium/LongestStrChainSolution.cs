using System.Collections.Generic;

namespace Learning.Shared.Classes.LeetCode.Medium {
    /// <summary>
    /// Class <c>LongestStrChainSolution</c> Solution to the: https://leetcode.com/problems/longest-string-chain/
    /// </summary>
    public class LongestStrChainSolution {
        // TODO: Add the memorization
        private HashSet<string>? vocabulary;

        public int LongestStrChain(string[] words) {
            vocabulary = new HashSet<string>(words);

            int result = -1;

            foreach (string word in words) {
                int intermediateResult = LongestContinuousSubsequence(word, 0);

                if (intermediateResult > 0) {
                    result = intermediateResult;
                }

            }

            return result;
        }

        private int LongestContinuousSubsequence(string word, int count) {
            if (word.Length == 1) {
                return count + 1;
            }

            int longestChain = -1;

            for (int idx = 0; idx < word.Length; idx++) {
                string intermediateWord = word.Remove(idx, 1);

                if (!vocabulary!.Contains(word)) {
                    continue;
                }

                int subResult = LongestContinuousSubsequence(intermediateWord, count);

                if (subResult > longestChain) {
                    longestChain = subResult;
                }
            }

            return longestChain + 1;
        }
    }
}