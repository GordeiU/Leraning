using System.Collections.Generic;

namespace Learning.Shared.Classes.LeetCode.Medium {
    /// <summary>
    /// Class <c>LongestStrChainSolution</c> Solution to the: https://leetcode.com/problems/longest-string-chain/
    /// </summary>
    public class LongestStrChainSolution {
        private HashSet<string>? vocabulary;
        private Dictionary<string, int>? wordPathLengths;

        public int LongestStrChain(string[] words) {
            vocabulary = new HashSet<string>(words);
            wordPathLengths = new Dictionary<string, int>();

            int result = 0;

            foreach (string word in words) {
                int intermediateResult = LongestContinuousSubsequence(word, 0);

                if (intermediateResult > result) {
                    result = intermediateResult;
                }

            }

            return result;
        }

        private int LongestContinuousSubsequence(string word, int count) {
            if (word.Length == 1) {
                return count + 1;
            }

            if (wordPathLengths!.ContainsKey(word)){
                return wordPathLengths[word];
            }

            int longestChain = 0;

            for (int idx = 0; idx < word.Length; idx++) {
                string intermediateWord = word.Remove(idx, 1);

                if (!vocabulary!.Contains(intermediateWord)) {
                    continue;
                }

                int subResult = LongestContinuousSubsequence(intermediateWord, count);
                wordPathLengths![intermediateWord] = subResult;

                if (subResult > longestChain) {
                    longestChain = subResult;
                }
            }

            return longestChain + 1;
        }
    }
}