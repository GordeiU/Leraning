using System;

namespace Learning.Shared.Classes.LeetCode.Medium {
    /// <summary>
    /// Class <c>DeleteOperationTwoStringsSolution</c> Solution to the: https://leetcode.com/problems/delete-operation-for-two-strings/
    /// </summary>
    public class DeleteOperationTwoStringsSolution {
        public int MinDistance(string wordOne, string wordTwo) {
            int longestSubsequenceCount = LongestStringSubsequence(wordOne, wordTwo);

            return wordOne.Length + wordTwo.Length - longestSubsequenceCount * 2;
        }

        private int LongestStringSubsequence(string wordOne, string wordTwo) {
            //TODO: Implement longest string subsequence recursive? algorithm
            throw new NotImplementedException();
        }
    }
}